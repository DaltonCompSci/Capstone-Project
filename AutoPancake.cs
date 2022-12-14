using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPancake : MonoBehaviour
{
    public bool CreatingPancake = false;
    public static int AutoIncrease = 1;
    public int InternalIncrease;


    
   

    // Update is called once per frame
    void Update()
    {
        AutoIncrease = GlobalGrandmas.totalGrandmas;
        InternalIncrease = AutoIncrease;
        if (CreatingPancake == false)
        {
            CreatingPancake = true;
            StartCoroutine(CreateThePancake());
        }

    }

    IEnumerator CreateThePancake()
    {
        ClickPancake.clicks += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingPancake = false;
    }


}
