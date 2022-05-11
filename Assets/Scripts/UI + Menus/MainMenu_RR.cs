using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu_RR : MonoBehaviour
{
        #region Methods
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1"); //loads level once
    }

    public void QuitGame()
    {
        Application.Quit(); //closes the game
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu"); //reloads the main menu
    }
        #endregion
}