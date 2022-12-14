using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YieldIncrease : MonoBehaviour
{
    public GameObject textbox;
    public static int Increase;
    public int cost = 1;
    public TMP_Text clickText;
    public GameObject fakeyield;
    public GameObject realyield;
    public GameObject fakeText;
    public GameObject realText;
    public int currentclicks;
    // Start is called before the first frame update
    public void ClickPrice()
    {
        if (ClickPancake.clicks >= cost)
        {
            Increase += 1;
            ClickPancake.clicks -= cost;
            cost = cost * 2;
            clickText.text = "Increases: " + Increase + " Cost: " + cost;
        }



    }

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
