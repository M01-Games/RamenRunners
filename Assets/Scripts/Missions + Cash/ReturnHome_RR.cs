using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnHome_RR : MonoBehaviour
{
        #region Variable
        //Variables (pulic can be changed in unity / private can ONLY be changed in script)
    public GameMenu_RR gameMenu_RR; //The game menu script
    public Cash_RR cash_RR; //The cash system script
    public GameObject Timer; //The timer UI within the gameUI
    public float additionalTime; //The amount of added time once a delivery is made
    public float timer; //The current amount of time left for a delivery to be completed within
    public float startTimer; //The starting amount of time there is at the start of
        #endregion

        #region Methods
    void Update() //Runs every frame
    {
        timer -= 1 * Time.deltaTime; //Removes 1 from the current timer value every second
        Timer.GetComponent<TMPro.TextMeshProUGUI>().text = "Time: " + timer.ToString("0"); //changes the text to display like "Time: 15"

        if( timer <= 0) //Checks if the timer is less or equal to 0 if so...
        {
            gameMenu_RR.GameResults(); //Runs the results menu for the game
            cash_RR.LevelEndFail(); //Runs the level fail result
        }
    }
    void OnTriggerEnter(Collider other) //This runs when the Hazard has been collided with another object
    {
        if(other.gameObject.CompareTag("Player")) //This makes sure that it was the player tha collided with the hazard and if it is then the script will run
        {
            Debug.Log("Player Detected"); //Tells the system to display the text in "..."
            gameMenu_RR.GameResults(); //Runs the results menu for the game
            cash_RR.LevelEndSuccess(); //Runs the level success result
        }
    }
    public void SetNewTimer() //The time reward protocall
    {
        timer += additionalTime; //Adds the time reward for a delivery on to the current time
    }
    public void SetPlayTimer() //The Starting timer protocall
    {
        timer = startTimer; //Sets the current timer to the starting timer value
    }
        #endregion
}