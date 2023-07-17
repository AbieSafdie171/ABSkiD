using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkiUI : MonoBehaviour
{

    private bool lone2Val = false;
    public AudioSource src;
    public AudioClip lone2;


    public void PlayEffect(){
        src.Play();        

    }


    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("BackMusic");
        if (objs.Length > 0)
            Destroy(objs[0]);
        src.Play();   
    }

    // Update is called once per frame
    void Update()
    {
        if (!src.isPlaying){
            if (lone2Val == false){
                src.clip = lone2;
                lone2Val = true;
                src.Play();
            }
        }
    }



}
