using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sasha_Kaplow : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coolness = 99;

    public static int speed = 85;

    public static int stamina = 80;

    public static int skiingIQ = 80;

    public static int alcTol = 90;

        public static void xFactor(Vector3 pos){


        GameObject[] objs = GameObject.FindGameObjectsWithTag("pickup");

        int c = objs.Length;

        Vector3 newPos = new Vector3(pos.x, pos.y, pos.z);

        newPos.y += 0.75f;
        newPos.x += 0f;
        newPos.z += 0.2f;

        for (int i = 0; i < c; i++)
        {
            if (objs[i].name != "Alcohol(Clone)")
                objs[i].transform.position = newPos;
        }              

    }
}
