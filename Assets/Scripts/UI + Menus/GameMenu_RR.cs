using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu_RR : MonoBehaviour
{
        #region Variable
        //Variables (pulic can be changed in unity / private can ONLY be changed in script)
    public GameObject gameUI; //The game play UI
    public GameObject gameMenu; //The gamestart menu
    public GameObject carPart1, carPart2, carPart3; //All the car parts for the player
    public GameObject gameStart; //The starting destination of the level
    public ReturnHome_RR returnHome_RR; //The return home script
    public GameObject policeCar1, policeCar2, policeCar3, policeCar4, policeCar5, policeCar6, policeCar7, policeCar8; //All the police cars
        #endregion

        #region Methods
    public void Play() //The play level protocall
    {
        gameUI.SetActive(true); //Turns on the game play UI
        gameMenu.SetActive(false); //Turns off the gamestart menu

        returnHome_RR.SetPlayTimer(); //Starts the delivery current timer
    }
    public void GameResults() //The game results protocall
    {
        Debug.Log("GameEnd"); //Tells the system to display the text in "..."
        gameUI.SetActive(false); //Turns off the game play UI
        gameMenu.SetActive(true); //Turns on the gamestart menu 

        carPart1.transform.position = gameStart.transform.position; //Sets the car part to the postition of the gamestart position
        carPart2.transform.position = gameStart.transform.position; //Sets the car part to the postition of the gamestart position
        carPart3.transform.position = gameStart.transform.position; //Sets the car part to the postition of the gamestart position
        carPart1.transform.rotation = gameStart.transform.rotation; //Sets the car part to the rotation of the gamestart rotation
        carPart1.transform.rotation = gameStart.transform.rotation; //Sets the car part to the rotation of the gamestart rotation
        carPart1.transform.rotation = gameStart.transform.rotation; //Sets the car part to the rotation of the gamestart rotation
    }
    public void GameModeEasy() //The easy mode protocall
    {
        policeCar1.SetActive(true); //Turns on the police car within the level
        policeCar2.SetActive(true); //Turns on the police car within the level
        policeCar3.SetActive(false); //Turns off the police car within the level
        policeCar4.SetActive(false); //Turns off the police car within the level
        policeCar5.SetActive(false); //Turns off the police car within the level
        policeCar6.SetActive(false); //Turns off the police car within the level
        policeCar7.SetActive(false); //Turns off the police car within the level
        policeCar8.SetActive(false); //Turns off the police car within the level
    }
    public void GameModeMedium() //The medium mode protocall
    {
        policeCar1.SetActive(true); //Turns on the police car within the level
        policeCar2.SetActive(true); //Turns on the police car within the level
        policeCar3.SetActive(true); //Turns on the police car within the level
        policeCar4.SetActive(true); //Turns on the police car within the level
        policeCar5.SetActive(true); //Turns on the police car within the level
        policeCar6.SetActive(false); //Turns off the police car within the level
        policeCar7.SetActive(false); //Turns off the police car within the level
        policeCar8.SetActive(false); //Turns off the police car within the level
    }
    public void GameModeHard() //The hard mode protocall
    {
        policeCar1.SetActive(true); //Turns on the police car within the level
        policeCar2.SetActive(true); //Turns on the police car within the level
        policeCar3.SetActive(true); //Turns on the police car within the level
        policeCar4.SetActive(true); //Turns on the police car within the level
        policeCar5.SetActive(true); //Turns on the police car within the level
        policeCar6.SetActive(true); //Turns on the police car within the level
        policeCar7.SetActive(true); //Turns on the police car within the level
        policeCar8.SetActive(true); //Turns on the police car within the level
    }
        #endregion
}