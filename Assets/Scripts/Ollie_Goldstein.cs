using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ollie_Goldstein : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coolness = 99;

    public static int speed = 75;

    public static int stamina = 75;

    public static int skiingIQ = 70;

    public static int alcTol = 80;

    public static Vector3 size = new Vector3(1f, 1f, 1f);

    
    public static void xFactor(){

        size.x = 0.2f;
        size.y = 0.5f;

        GameObject[] objs = GameObject.FindGameObjectsWithTag("obstacle");

        int c = objs.Length;

        for (int i = 0; i < c; i++)
        {
            objs[i].transform.localScale = size;
        }                

    }


    
}
