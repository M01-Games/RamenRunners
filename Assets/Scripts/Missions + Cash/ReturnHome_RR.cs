using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnHome_RR : MonoBehaviour
{
        #region Variable
        //Variables (pulic can be changed in unity / private can ONLY be changed in script)
    public GameMenu_RR gameMenu_RR;
    public Cash_RR cash_RR;

    public GameObject Timer;
    public float additionalTime;
    public float timer;
    public float startTimer;
        #endregion

        #region Methods
    void Update()
    {
        timer -= 1 * Time.deltaTime;
        Timer.GetComponent<TMPro.TextMeshProUGUI>().text = "Time: " + timer.ToString("0"); //changes the text to display like "Time: 15"

        if( timer <= 0)
        {
            gameMenu_RR.GameResults(); //Runs the results menu for the game
            cash_RR.LevelEndFail();
        }
    }
    void OnTriggerEnter(Collider other) //This runs when the Hazard has been collided with another object
    {
        if(other.gameObject.CompareTag("Player")) //This makes sure that it was the player tha collided with the hazard and if it is then the script will run
        {
            Debug.Log("Player Detected"); //Tells the system to display the text in "..."
            gameMenu_RR.GameResults(); //Runs the results menu for the game
            cash_RR.LevelEndSuccess();
        }
    }
    public void SetNewTimer()
    {
        timer += additionalTime;
    }
    public void SetPlayTimer()
    {
        timer = startTimer;
    }
        #endregion
}