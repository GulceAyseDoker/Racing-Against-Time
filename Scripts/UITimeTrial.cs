using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimeTrial : MonoBehaviour
{
    public Text TimeTrialMinutesG;
    public Text TimeTrialMinutesS;
    public Text TimeTrialMinutesB;
    public Text TimeTrialSecondsG;
    public Text TimeTrialSecondsS;
    public Text TimeTrialSecondsB;
    public Text WinMessage;
    public GameObject TimeTrialObject;
    public GameObject TimeTrialResults;
    public GameObject GoldStar;
    public GameObject SilverStar;
    public GameObject BronzeStar;   
    private bool Winner = false;
    // Start is called before the first frame update
    void Start()
    {
        TimeTrialObject.SetActive(true);
        TimeTrialResults.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         //Display Time Trial Gold
            if(SaveScript.TimeTrialMinG <= 9)
            {
                TimeTrialMinutesG.text = "0" + SaveScript.TimeTrialMinG.ToString() + ":";
            }
            if(SaveScript.TimeTrialMinG >= 10)
            {
                TimeTrialMinutesG.text = SaveScript.TimeTrialMinG.ToString() + ":";
            }
            if(SaveScript.TimeTrialSecondsG <= 9)
            {
                TimeTrialSecondsG.text = "0" + SaveScript.TimeTrialSecondsG.ToString();
            }
            if(SaveScript.TimeTrialSecondsG >= 10)
            {
                TimeTrialSecondsG.text = SaveScript.TimeTrialSecondsG.ToString();
            }

            //Display Time Trial Silver
            if(SaveScript.TimeTrialMinS <= 9)
            {
                TimeTrialMinutesS.text = "0" + SaveScript.TimeTrialMinS.ToString() + ":";
            }
            if(SaveScript.TimeTrialMinS >= 10)
            {
                TimeTrialMinutesS.text = SaveScript.TimeTrialMinS.ToString() + ":";
            }
            if(SaveScript.TimeTrialSecondsS <= 9)
            {
                TimeTrialSecondsS.text = "0" + SaveScript.TimeTrialSecondsS.ToString();
            }
            if(SaveScript.TimeTrialSecondsS >= 10)
            {
                TimeTrialSecondsS.text = SaveScript.TimeTrialSecondsS.ToString();
            }

            //Display Time Trial Bronze
            if(SaveScript.TimeTrialMinB <= 9)
            {
                TimeTrialMinutesB.text = "0" + SaveScript.TimeTrialMinB.ToString() + ":";
            }
            if(SaveScript.TimeTrialMinB >= 10)
            {
                TimeTrialMinutesB.text = SaveScript.TimeTrialMinB.ToString() + ":";
            }
            if(SaveScript.TimeTrialSecondsB <= 9)
            {
                TimeTrialSecondsB.text = "0" + SaveScript.TimeTrialSecondsB.ToString();
            }
            if(SaveScript.TimeTrialSecondsB >= 10)
            {
                TimeTrialSecondsB.text = SaveScript.TimeTrialSecondsB.ToString();
            }

            if(SaveScript.RaceOver == true)
            {
                if(Winner == false)
                {
                    Winner = true;
                    StartCoroutine(WinDisplay());
                }
            }
    }
    IEnumerator WinDisplay()
    {
        yield return new WaitForSeconds(0.15f);
        TimeTrialResults.SetActive(true);
        if(SaveScript.Gold == true)
        {
            WinMessage.text = "YOU WON GOLD";
            GoldStar.SetActive(true);

        }
        if(SaveScript.Silver == true)
        {
            WinMessage.text = "YOU WON SILVER";
            SilverStar.SetActive(true);
            
        }
        if(SaveScript.Bronze == true)
        {
            WinMessage.text = "YOU WON BRONZE";
            BronzeStar.SetActive(true);
            
        }
        if(SaveScript.Fail == true)
        {
            WinMessage.text = "TRY AGAIN";
            
        }
    }
}
