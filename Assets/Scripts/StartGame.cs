using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void OnMouseUp()
    {
        SceneManager.LoadScene("Main Game", LoadSceneMode.Single);
    }
}
