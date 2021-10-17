using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeCounter : MonoBehaviour
{
    public Text LivesCounter;

    GameSetup gameSetup = new GameSetup();

    MainGame mainGame;

    // Start is called before the first frame update
    void Start()
    {
        mainGame = GetComponent<MainGame>();

        gameSetup._lives = 3;

        print(gameSetup._lives);
    }

    // Update is called once per frame
    void Update()
    {
        LivesCounter.text = "Lives: " + gameSetup._lives.ToString();
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (gameSetup._lives > 0) 
            {
                mainGame.player.position = mainGame.PlayerStart;
                gameSetup._lives--;
            }
            else
            {
                gameSetup._lives--;
                SceneManager.LoadScene("End Screen", LoadSceneMode.Single);
            }
        }    
    }
}
