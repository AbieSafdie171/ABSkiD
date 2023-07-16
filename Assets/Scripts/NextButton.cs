using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{
    public AudioSource src;

    public void PlayEffect(){

        src.time = 1.05f;
        src.Play();        

    }
    public void NButton(){

        PlayEffect();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void PrevButton(){

        PlayEffect();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void BackButton (){
        
        PlayEffect();
        SceneManager.LoadScene("MainMenu");


    }

    
}
