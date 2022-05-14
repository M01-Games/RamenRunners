using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deliveries_RR : MonoBehaviour
{
        #region Variable
        //Variables (pulic can be changed in unity / private can ONLY be changed in script)
    public RandomDelivery_RR randomDelivery_RR;
    public Cash_RR cash_RR;
    public ReturnHome_RR returnHome_RR;
        #endregion

        #region Methods
        void OnTriggerEnter(Collider other) //This runs when the Hazard has been collided with another object
    {
        if(other.gameObject.CompareTag("Player")) //This makes sure that it was the player tha collided with the hazard and if it is then the script will run
        {
            Debug.Log("Delivery Completed"); //Tells the system to display the text in "..."
            randomDelivery_RR.NewDelivery();
            cash_RR.DeliveryCash();
            returnHome_RR.SetNewTimer();
            this.gameObject.SetActive(false);
        }
    }
        #endregion
}