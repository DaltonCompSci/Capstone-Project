using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalGrandmas : MonoBehaviour
{

    public GameObject fakeGrandma;
    public GameObject realGrandma;
    public TMP_Text fakeText;
    public TMP_Text realText;
    public int currentclicks;
    public static int grandmaCount = 50;
    public static int totalGrandmas;

  


    void Update()
    {
        currentclicks = ClickPancake.clicks;
        fakeText.text = "Grandma: " + grandmaCount;
        realText.text = "Grandma: " + grandmaCount;
        if (currentclicks >= grandmaCount)
        {
            fakeGrandma.SetActive(false);
            realGrandma.SetActive(true);
        }
        else
        {
            fakeGrandma.SetActive(true);
            realGrandma.SetActive(false);
        }


    }
}
