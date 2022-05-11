using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu_RR : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject gameMenu;

    public void GameResults()
    {
        SceneManager.LoadScene("Menus"); //loads the Menus scene
        mainMenu.SetActive(false);
        settingsMenu.SetActive(false);
        gameMenu.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
