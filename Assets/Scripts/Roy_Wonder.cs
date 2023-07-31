using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roy_Wonder : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coolness = 80;

    public static int speed = 70;

    public static int stamina = 60;

    public static int skiingIQ = 40;

    public static int alcTol = 70;


    public static void xFactor(Vector3 pos){


        GameObject[] objs = GameObject.FindGameObjectsWithTag("pickup");

        int c = objs.Length;

        Vector3 newPos = new Vector3(pos.x, pos.y, pos.z);



        for (int i = 0; i < c; i++)
        {
            float randX = Random.Range(-7f, 7f);
            float randZ = Random.Range(3f, 10f);

            newPos.y += 0.1f;
            newPos.x += randX;
            newPos.z += randZ;
            
            Instantiate(objs[i], new Vector3(newPos.x, newPos.y, newPos.z), Quaternion.identity, objs[i].transform.parent);


        }              

    }
}
