using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene(){
        int currentScene=SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene+1);
    }
    public void Quitgame(){
        Application.Quit();
    }

    public void LoadGameOverScene(){
        SceneManager.LoadScene("GameOver Scene");
    }

    public void LoadPlayAgain(){
        SceneManager.LoadScene("Level 1");
    }

    public void LoadMenu(){
        SceneManager.LoadScene("Menu Scene");
    }
}
