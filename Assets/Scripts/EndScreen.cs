using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    public Text EndText;

    void Awake()
    {
        print("Lives: " + PlayerStatistics.Lives.ToString());

        if (PlayerStatistics.Lives < 0) 
        {
            EndText.text = "You ran out of lives!\nTry again?";
        }
        else
        {
            EndText.text = "You won! Play again?";
        }
        
    }
}
