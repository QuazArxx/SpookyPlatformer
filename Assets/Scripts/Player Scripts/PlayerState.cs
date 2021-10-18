using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    public PlayerStatistics localPlayerData = new PlayerStatistics();

    StartPosition startPosition;

    public Text LivesCounter;

    void Awake()
    {
        startPosition = GetComponent<StartPosition>();
    }

    void Update()
    {
        LivesCounter.text = "Lives: " + localPlayerData.lives;
    }

    public void SavePlayer()
    {
        GlobalControl.Instance.savedPlayerData = localPlayerData;
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "OutOfBounds")
        {
            if (localPlayerData.lives > 0) 
            {
                startPosition.player.position = startPosition.PlayerStart;
                localPlayerData.lives--;
                print(localPlayerData.lives);
            }
            else
            {
                SceneManager.LoadScene("End Screen", LoadSceneMode.Single);
                localPlayerData.lives--;
            }
        }    
    }
}
