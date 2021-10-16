using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public void OnMouseUp () 
    {
        SceneManager.LoadScene("Start Menu", LoadSceneMode.Single);
    }
}
