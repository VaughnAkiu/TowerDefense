using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private string mainMenuScene = "MainMenuScene";
    private string gameScene = "GameScene";
    private string gameOverScene = "GameOverScene";



    public void PlayGame ()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(gameScene);
    }

    public void QuitGame ()
    {
        Debug.Log("Quitting Application");
        Application.Quit();
    }


}
