using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDelivery_RR : MonoBehaviour
{
        #region Variable
        //Variables (pulic can be changed in unity / private can ONLY be changed in script)
    public GameObject[] Deliveries; //The array of deliveries
    private int chance; //The random chance number
        #endregion

        #region Methods
    void Update() //Runs every frame
    {
        if(chance <= 10) //Checks if the chance is less or equal to 10 if so...
        {
            Deliveries[0].SetActive(true); //Turns on the first delivery location
        }
        if(chance <= 20 && chance > 10) //Checks if the chance is less or equal to 20 and greater than 10 if so...
        {
            Deliveries[1].SetActive(true); //Turns on the second delivery location
        }
        if(chance <= 30 && chance > 20) //Checks if the chance is less or equal to 30 and greater than 20 if so...
        {
            Deliveries[2].SetActive(true); //Turns on the third delivery location
        }
        if(chance <= 40 && chance > 30) //Checks if the chance is less or equal to 40 and greater than 30 if so...
        {
            Deliveries[3].SetActive(true); //Turns on the fourth delivery location
        }
        if(chance <= 50 && chance > 40) //Checks if the chance is less or equal to 50 and greater than 40 if so...
        {
            Deliveries[4].SetActive(true); //Turns on the fifth delivery location
        }
        if(chance <= 60 && chance > 50) //Checks if the chance is less or equal to 60 and greater than 50 if so...
        {
            Deliveries[5].SetActive(true); //Turns on the sixth delivery location
        }
        if(chance <= 70 && chance > 60) //Checks if the chance is less or equal to 70 and greater than 60 if so...
        {
            Deliveries[6].SetActive(true); //Turns on the seventh delivery location
        }
        if(chance <= 80 && chance > 70) //Checks if the chance is less or equal to 80 and greater than 70 if so...
        {
            Deliveries[7].SetActive(true); //Turns on the eighth delivery location
        }
        if(chance <= 90 && chance > 80) //Checks if the chance is less or equal to 90 and greater than 80 if so...
        {
            Deliveries[8].SetActive(true); //Turns on the ninth delivery location
        }
        if(chance <= 100 && chance > 90) //Checks if the chance is less or equal to 100 and greater than 90 if so...
        {
            Deliveries[9].SetActive(true); //Turns on the tenth delivery location
        }
    }
    public void NewDelivery() //The new delivery protocall
    {
        Debug.Log("New Delivery"); //Tells the system to display the text in "..."
        chance = Random.Range(0, 101); //Sets the chance to a random number from 1 to 100
    }
        #endregion
}