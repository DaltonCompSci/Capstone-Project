using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{

    public GameObject AutoPancake;

    public void StartAutoPancake()
    {
        AutoPancake.SetActive(true);
        ClickPancake.clicks -= GlobalGrandmas.grandmaCount;
        GlobalGrandmas.grandmaCount *= 2;
        GlobalGrandmas.totalGrandmas += 1;
    }





}
