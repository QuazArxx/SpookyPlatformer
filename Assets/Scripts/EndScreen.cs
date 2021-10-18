using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    public Text EndText;
    public PlayerStatistics localPlayerData = new PlayerStatistics();

    void Awake()
    {
        print("Lives: " + localPlayerData.lives.ToString());

        if (localPlayerData.lives == 0) 
        {
            EndText.text = "You ran out of lives!\nTry again?";
        }
        else
        {
            EndText.text = "You won! Play again?";
        }
        
    }
}
