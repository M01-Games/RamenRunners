using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDelivery_RR : MonoBehaviour
{
    public GameObject[] Deliveries;
    private int chance;

    // Update is called once per frame
    void Update()
    {
        if(chance <= 10)
        {
            Deliveries[0].SetActive(true);
        }
        if(chance <= 20 && chance > 10)
        {
            Deliveries[1].SetActive(true);
        }
        if(chance <= 30 && chance > 20)
        {
            Deliveries[2].SetActive(true);
        }
        if(chance <= 40 && chance > 30)
        {
            Deliveries[3].SetActive(true);
        }
        if(chance <= 50 && chance > 40)
        {
            Deliveries[4].SetActive(true);
        }
        if(chance <= 60 && chance > 50)
        {
            Deliveries[5].SetActive(true);
        }
        if(chance <= 70 && chance > 60)
        {
            Deliveries[6].SetActive(true);
        }
        if(chance <= 80 && chance > 70)
        {
            Deliveries[7].SetActive(true);
        }
        if(chance <= 90 && chance > 80)
        {
            Deliveries[8].SetActive(true);
        }
        if(chance <= 100 && chance > 90)
        {
            Deliveries[9].SetActive(true);
        }
    }

    public void NewDelivery()
    {
        Debug.Log("New Delivery"); //Tells the system to display the text in "..."
        chance = Random.Range(0, 101);
    }
}