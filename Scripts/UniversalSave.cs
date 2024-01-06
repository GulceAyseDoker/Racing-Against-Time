using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalSave : MonoBehaviour
{
    public static int LapCounts;
    public static int OpponentCount;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        
    }

    
}
