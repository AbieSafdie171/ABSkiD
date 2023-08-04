using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abie_Safdie : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coolness = 45;

    public static int speed = 99;

    public static int stamina = 40;

    public static int skiingIQ = 35;

    public static int alcTol = 5;


    public static void xFactor(){


        GameObject[] objs = GameObject.FindGameObjectsWithTag("obstacle");

        int c = objs.Length;

        for (int i = 0; i < c; i++)
        {
            Destroy(objs[i]);
        }                

    }



    
}
