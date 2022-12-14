using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pancakechance : MonoBehaviour
{
    // Start is called before the first frame update

    IDictionary<int, string> pancakes = new Dictionary<int, string>();

    public void PancakeChance()
    {
        pancakes.Add(1, pancaketypes.buttered);

        if (pancaketypes.chocolate == true)
        {
            pancakes.Add(2, pancaketypes.chocolate);
        }
        else if (pancaketypes.spooky == true)
        {
            pancakes.Add(3, pancaketypes.spooky);
        }

    }




    // Update is called once per frame
    void Update()
    {
        

    }
}
