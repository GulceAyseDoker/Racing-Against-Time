using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
    //private AudioSource Player;
    private bool IsPlaying = false;
    public int CurrentWP = 0;
    public int ThisWPNumber;
    public int LastWPNumber;

    // Start is called before the first frame update
    void Start()
    {
        //Player = GetComponent<AudioSource>();
    }



    // Update is called once per frame
    // If you go wrong way a message will be displayed on consol.
    void Update()
    {
        if(SaveScript.LapChange == true)
        {
            CurrentWP = 0;
        }
        if(CurrentWP > LastWPNumber)
        {
            StartCoroutine(CheckDirection());
        }
        if(LastWPNumber > ThisWPNumber)
        {
            SaveScript.WrongWay = false;
        }
        if(LastWPNumber < ThisWPNumber)
        {
            SaveScript.WrongWay = true;
        }
    }


    IEnumerator CheckDirection()
    {
        yield return new WaitForSeconds(0.5f);
        ThisWPNumber = LastWPNumber;
    }


}
