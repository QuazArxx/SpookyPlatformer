using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    public Text EndText;
    GameSetup gameSetup = new GameSetup();

    void Awake()
    {
        print("Lives: " + gameSetup._lives.ToString());

        if (gameSetup._lives == 0) 
        {
            EndText.text = "You ran out of lives!\nTry again?";
        }
        else
        {
            EndText.text = "You won! Play again?";
        }
        
    }
}
