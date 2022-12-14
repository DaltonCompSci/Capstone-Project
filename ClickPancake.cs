using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickPancake : MonoBehaviour
{
    public GameObject circlePrefab;

    public Vector3 center;
    public Vector3 size;
    public static int clicks = 0;
    public TMP_Text clickText;
    

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //mouse hit detection that runs spawnnextcircle method

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        if (hit.collider != null)
        {

            if (hit.collider.tag == "Pancake Respawn")
            {

                if (Input.GetMouseButtonDown(0))
                {
                    
                    SpawnNextCircle();
                    clicks += YieldIncrease.Increase + 1;

                }
            }

        }
        clickText.text = "Money: " + clicks;

    }
    //spawns in next circle while destroying last one.
    public void SpawnNextCircle()
    {
        //random pancake spawn
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2),
                                           Random.Range(-size.y / 2, size.y / 2),
                                           0);
        Instantiate(circlePrefab, pos, Quaternion.identity);
        Destroy(gameObject);
    }
}
