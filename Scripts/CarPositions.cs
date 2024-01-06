using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPositions : MonoBehaviour
{
    public GameObject Slot1;
    public GameObject Stats;

    public int pos;
    public bool Player;

    // Start is called before the first frame update
    void Start()
    {
        if(Player == true)
        {
            pos = FinishLine.PlayerFinishPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(pos == 0)
        {
            Stats.SetActive(false);
        }

        if(pos == 1)
        {
            Stats.transform.position = Slot1.transform.position;
        }
    }
}
