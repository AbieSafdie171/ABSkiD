using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{

    public AudioSource src;

    public void PlayEffect(){

        src.time = 1.05f;
        src.Play();        

    }

    public void BackButton (){
        
        PlayEffect();
        SceneManager.LoadScene("MainMenu");


    }

    public void PlayButton(){
        PlayEffect();
        SceneManager.LoadScene("SkiScene");
    }
}
