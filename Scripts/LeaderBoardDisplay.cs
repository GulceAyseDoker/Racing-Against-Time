using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoardDisplay : MonoBehaviour
{

    public Text Position;
    public bool Player;

    // Update is called once per frame
    void Update()
    {
        if(Player == true)
        {
            Position.text = "YOU FINISHED IN " + SaveScript.PlayerPosition + ". PLACE!";
        }
    }
}
