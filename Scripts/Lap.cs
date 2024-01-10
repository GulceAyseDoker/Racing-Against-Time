using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lap : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            // Tracks lap number and best lap until game is over.
            // Also updaset the checkpoint info. Makes them false after we start other lap and initializes it's last pas time.
            if(SaveScript.RaceOver == false)
            {
                if(SaveScript.HalfWayActivated == true)
                {
                    SaveScript.HalfWayActivated = false;
                    SaveScript.LastLapM = SaveScript.LapTimeMinutes;
                    SaveScript.LastLapS = SaveScript.LapTimeSeconds;
                    SaveScript.LapNumber++;
                    SaveScript.LapChange = true;
                    if(SaveScript.LapNumber == 2)
                    {
                        SaveScript.BestLapTimeM = SaveScript.LastLapM;
                        SaveScript.BestLapTimeS = SaveScript.LastLapS;
                    }

                    SaveScript.CheckPointPass1 = false;
                    SaveScript.CheckPointPass2 = false;

                    SaveScript.LastCheckPoint1 = SaveScript.ThisCheckPoint1;
                    SaveScript.LastCheckPoint2 = SaveScript.ThisCheckPoint2;
                }
            }
        }


        if(other.gameObject.CompareTag("ProgressAI1"))
        {
            SaveScript.AICar1LapNumber++;
        }
        if(other.gameObject.CompareTag("ProgressAI2"))
        {
            SaveScript.AICar2LapNumber++;
        }


    }
}
