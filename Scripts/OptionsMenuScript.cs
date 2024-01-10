using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenuScript : MonoBehaviour
{
    public Text Mode;
    public Text LapCount;
    public Text OpponentCount;
    private bool TimeTrial = true;
    private int CurrentLapCount = 1;
    private int CurrentOpponentCount = 2;
    public int TimeTrialSceneNumber;
    public int RaceTrackSceneNumber;
    public GameObject LoadScreen;
    public GameObject OpponentsOn;
    public GameObject LapsOn;

    // Menu's UI for race type, opponents number, lap count.
    // Game start.
    public void ModeNext()
    {
        if(TimeTrial == true)
        {
            Mode.text = "RACE";
            TimeTrial = false;
            OpponentsOn.SetActive(true);
            //LapsOn.SetActive(true);
        }
    }

    public void ModeBack()
    {
        if (TimeTrial == false)
        {
            Mode.text = "TIME TRIAL";
            TimeTrial = true;
            OpponentsOn.SetActive(false);
            // LapsOn.SetActive(false);
        }
    }

    public void LapCountNext()
    {
        if (CurrentLapCount < 12)
        {
            CurrentLapCount ++;
            LapCount.text = CurrentLapCount + " LAPS";
            UniversalSave.LapCounts = CurrentLapCount;
        }
    }
    public void LapCountBack()
    {
        if (CurrentLapCount > 2)
        {
            CurrentLapCount --;
            LapCount.text = CurrentLapCount + " LAPS";
            UniversalSave.LapCounts = CurrentLapCount;
        }
        if (CurrentLapCount == 2)
        {
            CurrentLapCount--;
            LapCount.text = CurrentLapCount + " LAP";
            UniversalSave.LapCounts = CurrentLapCount;
        }
    }
/*     public void OpponentsNext()
    {
        if(CurrentOpponentCount < 2)
        {
            CurrentOpponentCount++;
            OpponentCount.text = CurrentOpponentCount + " OPPONENTS";
            UniversalSave.OpponentCount = CurrentOpponentCount;

        }
    }
    public void OpponentsBack()
    {
        if (CurrentOpponentCount == 2)
        {
            CurrentOpponentCount--;
            OpponentCount.text = CurrentOpponentCount + " OPPONENT";
            UniversalSave.OpponentCount = CurrentOpponentCount;

        }
    } */

    public void BeginRace()
    {
        if(TimeTrial == true)
        {
            StartCoroutine(WaitToLoad());
        }
        if (TimeTrial == false)
        {
            StartCoroutine(WaitToLoad2());
        }
    }
    IEnumerator WaitToLoad()
    {
        yield return new WaitForSeconds(0.3f);
        LoadScreen.SetActive(true);
        UniversalSave.LapCounts = CurrentLapCount;
        SceneManager.LoadScene(TimeTrialSceneNumber);
    }
    IEnumerator WaitToLoad2()
    {
        yield return new WaitForSeconds(0.3f);
        LoadScreen.SetActive(true);
        UniversalSave.LapCounts = CurrentLapCount;
        UniversalSave.OpponentCount = CurrentOpponentCount;
        SceneManager.LoadScene(RaceTrackSceneNumber);
    }
}
