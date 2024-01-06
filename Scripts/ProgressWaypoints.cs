using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressWaypoints : MonoBehaviour
{
    public int WPNumber; 
    public int CarTracking = 0;
    public int Position = 0;
    
    private int Lap1Position = 0;
    private int Lap2Position = 0;
    private int Lap3Position = 0;
    private int Lap4Position = 0;
    private int Lap5Position = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Progress"))
        {
            CarTracking = other.GetComponent<ProgressTracker>().CurrentWP;
            if(CarTracking < WPNumber)
            {
                other.GetComponent<ProgressTracker>().CurrentWP = WPNumber;
                // Debug.Log("Current WP = " + other.GetComponent<ProgressTracker>().CurrentWP);
                
                if(SaveScript.LapNumber == 1)
                {
                    Lap1Position++;
                    SaveScript.PlayerPosition = Lap1Position;
                }
                if(SaveScript.LapNumber == 2)
                {
                    Lap2Position++;
                    SaveScript.PlayerPosition = Lap2Position;
                }
                if(SaveScript.LapNumber == 3)
                {
                    Lap3Position++;
                    SaveScript.PlayerPosition = Lap3Position;
                }
                if(SaveScript.LapNumber == 4)
                {
                    Lap4Position++;
                    SaveScript.PlayerPosition = Lap4Position;
                }
                if(SaveScript.LapNumber == 5)
                {
                    Lap5Position++;
                    SaveScript.PlayerPosition = Lap5Position;
                }
            }

            if(CarTracking > WPNumber)
            {

                other.GetComponent<ProgressTracker>().LastWPNumber = WPNumber;

            }
        }

        if(other.gameObject.CompareTag("ProgressAI1"))
        {
            if(SaveScript.AICar1LapNumber == 1)
            {
                Lap1Position++;
            }
            if(SaveScript.AICar1LapNumber == 2)
            {
                Lap2Position++;
            }
            if(SaveScript.AICar1LapNumber == 3)
            {
                Lap3Position++;
            }
            if(SaveScript.AICar1LapNumber == 4)
            {
                Lap4Position++;
            }
            if(SaveScript.AICar1LapNumber == 5)
            {
                Lap5Position++;
            }
        }

        if(other.gameObject.CompareTag("ProgressAI2"))
        {
            if(SaveScript.AICar2LapNumber == 1)
            {
                Lap1Position++;
            }
            if(SaveScript.AICar2LapNumber == 2)
            {
                Lap2Position++;
            }
            if(SaveScript.AICar2LapNumber == 3)
            {
                Lap3Position++;
            }
            if(SaveScript.AICar2LapNumber == 4)
            {
                Lap4Position++;
            }
            if(SaveScript.AICar2LapNumber == 5)
            {
                Lap5Position++;
            }
        }

    }
}
