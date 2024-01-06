using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Image SpeedRing;
    public float DisplaySpeed;
    public Text SpeedText;
    public Text LapNumberText;
    public Text TotalLapsText;
    public Text LapTimeMinutesText;
    public Text LapTimeSecondsText;
    public Text RaceTimeMinutesText;
    public Text RaceTimeSecondsText;
    public Text BestLapTimeMinutes;
    public Text BestLapTimeSeconds;
    public Text TotalCarsText;
    //public Text WrongWayT;
    //public GameObject WrongWayText;
    public Text CheckPointTime;
    public Text PlayersPosition;
    
    public GameObject CheckPointDisplay;
    public int TotalLaps = 3;
    public int TotalCars = 1;
    // Start is called before the first frame update
    void Start()
    {
            SpeedRing.fillAmount = 0;
            SpeedText.text = "0";
            LapNumberText.text = "0";  
            TotalLapsText.text = "/" + TotalLaps.ToString();
            CheckPointDisplay.SetActive(false);
            SaveScript.MaxLaps = TotalLaps;
            TotalCarsText.text = "/" + TotalCars.ToString();
            //WrongWayText.SetActive(false);
            PlayersPosition.text = "1";

    }

    // Update is called once per frame
    void Update()
    {
        PlayersPosition.text = SaveScript.PlayerPosition.ToString();
        //Speed
        DisplaySpeed = SaveScript.Speed / SaveScript.TopSpeed;
        SpeedRing.fillAmount = DisplaySpeed;
        SpeedText.text = SaveScript.Speed.ToString();
        //LapNumber
        LapNumberText.text = SaveScript.LapNumber.ToString();

        //LapTime
        if(SaveScript.LapTimeMinutes <= 9)
        {
            LapTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
        }
        else if (SaveScript.LapTimeMinutes >= 10)
        {
            LapTimeMinutesText.text = (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
        }
        if (SaveScript.LapTimeSeconds <= 9)
        {
            LapTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        }
        else if (SaveScript.LapTimeSeconds >= 10)
        {
            LapTimeSecondsText.text = (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        }

        //Display Race time
        if(SaveScript.RaceTimeMinutes <= 9)
        {
            RaceTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.RaceTimeMinutes).ToString()) + ":";
        }
        else if (SaveScript.RaceTimeMinutes >= 10)
        {
            RaceTimeMinutesText.text = (Mathf.Round(SaveScript.RaceTimeMinutes).ToString()) + ":";
        }
        if (SaveScript.RaceTimeSeconds <= 9)
        {
            RaceTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        }
        else if (SaveScript.RaceTimeSeconds >= 10)
        {
            RaceTimeSecondsText.text = (Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        }

        //BEst Lap Time
        if(SaveScript.LastLapM == SaveScript.BestLapTimeM)
        {
            if(SaveScript.LastLapS < SaveScript.BestLapTimeS)
            {
                SaveScript.BestLapTimeS = SaveScript.LastLapS;
            }
        }
        if(SaveScript.LastLapM < SaveScript.BestLapTimeM)
        {
            SaveScript.BestLapTimeM = SaveScript.LastLapM;
            SaveScript.BestLapTimeS = SaveScript.LastLapS;
        }

        //Display BEst LAp time
        if(SaveScript.BestLapTimeM <= 9)
        {
            BestLapTimeMinutes.text = "0" + (Mathf.Round(SaveScript.BestLapTimeM).ToString()) + ":";
        }
        else if (SaveScript.BestLapTimeM >= 10)
        {
            BestLapTimeMinutes.text = (Mathf.Round(SaveScript.BestLapTimeM).ToString()) + ":";
        }
        if (SaveScript.BestLapTimeS <= 9)
        {
            BestLapTimeSeconds.text = "0" + (Mathf.Round(SaveScript.BestLapTimeS).ToString());
        }
        else if (SaveScript.BestLapTimeS >= 10)
        {
            BestLapTimeSeconds.text = (Mathf.Round(SaveScript.BestLapTimeS).ToString());
        }
        //CheckPoint working out for CheckPoint 1
        if(SaveScript.CheckPointPass1 == true)
        {
            SaveScript.CheckPointPass1 = false;
            CheckPointDisplay.SetActive(true);

            if(SaveScript.ThisCheckPoint1 > SaveScript.LastCheckPoint1)
            {
                CheckPointTime.color = Color.red;
                CheckPointTime.text = "-" + (SaveScript.ThisCheckPoint1 - SaveScript.LastCheckPoint1).ToString();
                StartCoroutine(CheckPointOff());
            }

            if(SaveScript.ThisCheckPoint1 < SaveScript.LastCheckPoint1)
            {
                CheckPointTime.color = Color.green;
                CheckPointTime.text = "+" + (SaveScript.LastCheckPoint1 - SaveScript.ThisCheckPoint1).ToString();
                StartCoroutine(CheckPointOff());
            }
        }

        //CheckPoint working out for CheckPoint 2
        if(SaveScript.CheckPointPass2 == true)
        {
            SaveScript.CheckPointPass2 = false;
            CheckPointDisplay.SetActive(true);

            if(SaveScript.ThisCheckPoint2 > SaveScript.LastCheckPoint2)
            {
                CheckPointTime.color = Color.red;
                CheckPointTime.text = "-" + (SaveScript.ThisCheckPoint2 - SaveScript.LastCheckPoint2).ToString();
                StartCoroutine(CheckPointOff());
            }

            if(SaveScript.ThisCheckPoint2 < SaveScript.LastCheckPoint2)
            {
                CheckPointTime.color = Color.green;
                CheckPointTime.text = "+" + (SaveScript.LastCheckPoint2 - SaveScript.ThisCheckPoint2).ToString();
                StartCoroutine(CheckPointOff());
            }

            //Display position
            
            
        }

        //Wrong way message
        //if(SaveScript.WrongWay == true)
        //{
        //WrongWayText.SetActive(true);
        //}
        //if (SaveScript.WrongWay == false)
        //{
          // WrongWayText.SetActive(false);
    //}
 
    }

    IEnumerator CheckPointOff()
    {
        yield return new WaitForSeconds(2);
        CheckPointDisplay.SetActive(false);
    }
}
