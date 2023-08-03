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

    public static GameObject palmTree;

    public GameObject temp;

    public void start(){
        palmTree = temp;
    }

    public static void xFactor(Vector3 pos){


        GameObject[] objs = GameObject.FindGameObjectsWithTag("pickup");

        int c = objs.Length;

        Vector3 newPos = new Vector3(pos.x, pos.y, pos.z);

        newPos.y += 0.75f;
        newPos.x += 0f;
        newPos.z += 0.2f;

        int counter = 0;

        for (int i = 0; i < c; i++)
        {
            if (objs[i].name == "X-Factor(Clone)")
                counter++;

            if (objs[i].name != "X-Factor(Clone)" && objs[i].name != "Alcohol(Clone)"){
                objs[i].transform.position = newPos;}
            else {
                if (counter < 3 && objs[i].name != "Alcohol(Clone)")
                    objs[i].transform.position = newPos;
            }


        }              

    }

    public static void israeliXFactor(Vector3 pos){

        Vector3 newPos = new Vector3(pos.x, pos.y, pos.z);



        for (int i = 0; i < 1; i++){

            newPos.y += 0.1f;
            newPos.x += 10f;
            newPos.z += 10f;
            
            Instantiate(palmTree, new Vector3(newPos.x, newPos.y, newPos.z), Quaternion.identity);

        }     
    }



}
