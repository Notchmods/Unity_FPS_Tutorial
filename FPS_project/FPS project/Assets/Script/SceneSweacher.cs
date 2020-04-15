using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSweacher : MonoBehaviour {
    
    public void FPS()
    {
        SceneManager.LoadScene(1);
    }

    public void Exitflow()
    {
        Application.Quit();
        Debug.Log("You've exited the game");
    }
}
