using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pancaketypes : MonoBehaviour
{
    public int chocycost = 400;
    public int spookycost = 1500;
    public int currentclicks;
    public void int chocmult;
    public void int spookmult;
    // Start is called before the first frame update
    public void chocolate()
    {
        chocolate == false;
        if (ClickPancake.clicks >= chocycost)
        {
            ClickPancake.clicks -= chocycost;
            chocolate == true;
        }
            chocmult = 5;
    }

    public void spooky()
    {
        spooky == false;
        if (ClickPancake.clicks >= chocycost)
        {
            ClickPancake.clicks -= spookycost;
            spooky == true;
        }
            
        spookmult = 20;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
