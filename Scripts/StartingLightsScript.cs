using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingLightsScript : MonoBehaviour
{
    public GameObject RLightOff;
    public GameObject RLightOn;
    public GameObject ALightOff;
    public GameObject ALightOn;
    public GameObject GLightOff;
    public GameObject GLightOn;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(StartingLights());

    }

    IEnumerator StartingLights()
    {
        yield return new WaitForSeconds(1);
        RLightOff.SetActive(false);
        RLightOn.SetActive(true);

        yield return new WaitForSeconds(1);
        RLightOff.SetActive(true);
        RLightOn.SetActive(false);
        
        ALightOff.SetActive(false);
        ALightOn.SetActive(true);

        yield return new WaitForSeconds(1);
        ALightOff.SetActive(true);
        ALightOn.SetActive(false);

        GLightOff.SetActive(false);
        GLightOn.SetActive(true);

        yield return new WaitForSeconds(0.5f);
        SaveScript.RaceStart = true;

    }


}
