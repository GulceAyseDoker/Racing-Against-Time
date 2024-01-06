using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RaceTrackMenu : MonoBehaviour
{
    public GameObject TrackOptions;
    public GameObject TrackOptions2;
    public GameObject TrackOptions3;
    

    public void OptionsOnPast()
    {
        TrackOptions.SetActive(true);
        TrackOptions2.SetActive(false);
        TrackOptions3.SetActive(false);

    }

    public void OptionsOffPast()
    {
        TrackOptions.SetActive(false);
        TrackOptions2.SetActive(true);
        TrackOptions3.SetActive(true);
    }
    
    public void OptionsOnFuture()
    { TrackOptions2.SetActive(false);
        TrackOptions3.SetActive(false);
        TrackOptions.SetActive(true);
       

    }

    public void OptionsOffFuture()
    {
        TrackOptions.SetActive(false);
        TrackOptions2.SetActive(true);
        TrackOptions3.SetActive(true);
    }

}
