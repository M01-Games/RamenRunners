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

    public void Play()
    {
        carPart1.SetActive(true);
        carPart2.SetActive(true);
        carPart3.SetActive(true);

        gameUI.SetActive(true);
        gameMenu.SetActive(false);
    }
    public void GameResults()
    {
        carPart1.SetActive(false);
        carPart2.SetActive(false);
        carPart3.SetActive(false);

        gameUI.SetActive(false);
        gameMenu.SetActive(true);

        carPart1.transform.position = gameStart.transform.position;
        carPart2.transform.position = gameStart.transform.position;
        carPart3.transform.position = gameStart.transform.position;

        carPart1.transform.Rotate(0f, 90f, 0f);
        carPart2.transform.Rotate(0f, 90f, 0f);
        carPart3.transform.Rotate(0f, 90f, 0f);
    }
}