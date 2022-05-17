using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu_RR : MonoBehaviour
{
    public GameObject gameUI;
    public GameObject gameMenu;

    public GameObject carPart1, carPart2, carPart3;
    public GameObject gameStart;

    public ReturnHome_RR returnHome_RR;

    public GameObject policeCar1, policeCar2, policeCar3, policeCar4, policeCar5, policeCar6, policeCar7, policeCar8;
    public void Play()
    {
        gameUI.SetActive(true);
        gameMenu.SetActive(false);

        returnHome_RR.SetPlayTimer();
    }
    public void GameResults()
    {
        gameUI.SetActive(false);
        gameMenu.SetActive(true);

        carPart1.transform.position = gameStart.transform.position;
        carPart2.transform.position = gameStart.transform.position;
        carPart3.transform.position = gameStart.transform.position;

        carPart1.transform.rotation = gameStart.transform.rotation;
        carPart1.transform.rotation = gameStart.transform.rotation;
        carPart1.transform.rotation = gameStart.transform.rotation;

    }
    public void GameModeEasy()
    {
        policeCar1.SetActive(true);
        policeCar2.SetActive(true);
        policeCar3.SetActive(false);
        policeCar4.SetActive(false);
        policeCar5.SetActive(false);
        policeCar6.SetActive(false);
        policeCar7.SetActive(false);
        policeCar8.SetActive(false);
    }
    public void GameModeMedium()
    {
        policeCar1.SetActive(true);
        policeCar2.SetActive(true);
        policeCar3.SetActive(true);
        policeCar4.SetActive(true);
        policeCar5.SetActive(true);
        policeCar6.SetActive(false);
        policeCar7.SetActive(false);
        policeCar8.SetActive(false);
    }
    public void GameModeHard()
    {
        policeCar1.SetActive(true);
        policeCar2.SetActive(true);
        policeCar3.SetActive(true);
        policeCar4.SetActive(true);
        policeCar5.SetActive(true);
        policeCar6.SetActive(true);
        policeCar7.SetActive(true);
        policeCar8.SetActive(true);
    }
}