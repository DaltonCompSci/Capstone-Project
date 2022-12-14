using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PriceMultiplier : MonoBehaviour
{
    public static int Multiply = 1;
    public int cost = 100;
    public TMP_Text clickText;
    public GameObject fakeyield;
    public GameObject realyield;
    public GameObject fakeText;
    public GameObject realText;
    public int currentclicks;

    public void MultipyPrice()
    {
        if (ClickPancake.clicks >= cost)
        {
            Multiply += 1;
            ClickPancake.clicks -= cost;
            cost = cost * 2;
            clickText.text = "Multiplier: x" + Multiply + " Cost: " + cost;
        }

    }

    // Update is called once per frame
    void Update()
    {
        currentclicks = ClickPancake.clicks;
        if (currentclicks >= cost)
        {
            fakeyield.SetActive(false);
            realyield.SetActive(true);
        }
        else
        {
            fakeyield.SetActive(true);
            realyield.SetActive(false);
        }


    }
}
