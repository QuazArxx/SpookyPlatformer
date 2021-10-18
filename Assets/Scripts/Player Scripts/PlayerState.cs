using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    StartPosition startPosition;

    public Text LivesCounter;

    void Start()
    {
        startPosition = GetComponent<StartPosition>();
        PlayerStatistics.Lives = 3;
    }

    void Update()
    {
        if (PlayerStatistics.Lives >= 0) {
            LivesCounter.text = "Lives: " + PlayerStatistics.Lives;
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "OutOfBounds")
        {
            if (PlayerStatistics.Lives > 0) 
            {
                startPosition.player.position = startPosition.PlayerStart;
                PlayerStatistics.Lives--;
            }
            else
            {
                SceneManager.LoadScene("End Screen", LoadSceneMode.Single);
                PlayerStatistics.Lives--;
            }
        }    
    }
}
