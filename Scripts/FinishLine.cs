using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject EndingPosition;
    public static int PlayerFinishPosition;

    private void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SaveScript.FinishPositionID++;
            PlayerFinishPosition = SaveScript.FinishPositionID;
            SaveScript.RaceOver = true;
            Time.timeScale = 0.2f;
            EndingPosition.SetActive(true);
        }
    }
}
