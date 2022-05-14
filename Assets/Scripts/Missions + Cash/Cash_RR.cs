using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cash_RR : MonoBehaviour
{
    public int playerCash = 0;
    public int pendingPlayerCash = 0;

    public GameObject cashDisplay; //the text within the start UI
    public GameObject deliveryCashDisplay; //the text within the level

    public ReturnHome_RR returnHome_RR;
    public GameObject notEnoughCash;

    void Update()
    {
        cashDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "Cash: ¥" + playerCash; //changes the text to display like "cash: 0"
        deliveryCashDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "Cash: ¥" + pendingPlayerCash; //changes the text to display like "cash: 0"
    }

    public void DeliveryCash()
    {
        pendingPlayerCash += 100;
    }
    public void LevelEndSuccess()
    {
        playerCash = pendingPlayerCash;
        pendingPlayerCash = 0;
    }
    public void LevelEndFail()
    {
        pendingPlayerCash = 0;
    }
    public void TimerUpgreade()
    {
        if(playerCash < 500)
        {
            StartCoroutine(NotEnoughCash());
        }
        else
        {
        playerCash -= 500;
        returnHome_RR.additionalTime += 5f;
        returnHome_RR.timer += 5f;
        returnHome_RR.startTimer += 5f;
        }
    }
    IEnumerator NotEnoughCash()
    {
        notEnoughCash.SetActive(true);
        yield return new WaitForSeconds(2);
        notEnoughCash.SetActive(false);
    }
}