using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionSystem_RR : MonoBehaviour
{
        #region Variable
        //Variables (pulic can be changed in unity / private can ONLY be changed in script)
    public GameMenu_RR gameMenu_RR; //The game menu script
    public Cash_RR cash_RR; //The cash system script
        #endregion

        #region Methods
        void OnTriggerEnter(Collider other) //This runs when the Hazard has been collided with another object
    {
        if(other.gameObject.CompareTag("Player")) //This makes sure that it was the player tha collided with the hazard and if it is then the script will run
        {
            Debug.Log("Player Detected"); //Tells the system to display the text in "..."
            gameMenu_RR.GameResults(); //Runs the results menu for the game
            cash_RR.LevelEndFail(); //Runs the level fail result
        }
    }
        #endregion
}