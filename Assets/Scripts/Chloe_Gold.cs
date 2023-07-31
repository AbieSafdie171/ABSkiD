using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chloe_Gold : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coolness = 75;

    public static int speed = 60;

    public static int stamina = 70;

    public static int skiingIQ = 70;

    public static int alcTol = 45;

    public static void xFactor(Vector3 pos){


        GameObject[] objs = GameObject.FindGameObjectsWithTag("pickup");

        int c = objs.Length;

        Vector3 newPos = new Vector3(pos.x, pos.y, pos.z);

        float randX = Random.Range(-7f, 7f);
        float randZ = Random.Range(25f, 60f);

        newPos.y += 0.75f;
        newPos.x += randX;
        newPos.z += randZ;

        int counter = 0;

        for (int i = 0; i < c; i++)
        {
            if (objs[i].name == "Alcohol(Clone)")
                counter++;

            if (objs[i].name != "Alcohol(Clone)"){
                objs[i].transform.position = newPos;
            } else {
                if (counter < 2)
                    objs[i].transform.position = newPos;
            }
        }              

    }
}
