using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    //Load gamescene
    public void GameMode()
    {
        SceneManager.LoadScene("GameMode");
    }

    //Go back to mainmenu
    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //Quit application
    public void QuitGame()
    {
        Application.Quit();
    }
}
