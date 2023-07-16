using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake(){

        GameObject[] objs = GameObject.FindGameObjectsWithTag("ClickSFX");

        if (objs.Length > 2)
        {
            Destroy(objs[0]);
        }

        DontDestroyOnLoad(gameObject);


    }
}
