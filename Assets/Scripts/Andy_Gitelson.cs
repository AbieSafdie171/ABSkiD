using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andy_Gitelson : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coolness = 65;

    public static int speed = 40;

    public static int stamina = 65;

    public static int skiingIQ = 70;

    public static int alcTol = 85;

    public static Vector3 size = new Vector3(1f, 1f, 1f);


    public static void xFactor(){

        float randX = Random.Range(0.2f, 1.2f);
        float randY = Random.Range(0.2f, 2.2f);

        size.x = randX;
        size.y = randY;


        GameObject[] objs = GameObject.FindGameObjectsWithTag("obstacle");

        int c = objs.Length;

        for (int i = 0; i < c; i++)
        {
            objs[i].transform.localScale = size;
        }                

    }
}
