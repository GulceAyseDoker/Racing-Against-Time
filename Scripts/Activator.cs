using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject FinishPoint;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Progress"))
        {
            SaveScript.HalfWayActivated = true;
            if(SaveScript.LapNumber == SaveScript.MaxLaps)
            {
                FinishPoint.SetActive(true);
            }
        }
    }
}
