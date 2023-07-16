using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public AudioSource src;

    public void PlayEffect(){

        src.time = 1.05f;
        src.Play();        

    }

    public void CharacterSelect(){

        PlayEffect();

        SceneManager.LoadScene("Abie_Safdie");

        
    }

        

    

    public void HowToPlay(){

        PlayEffect();
        SceneManager.LoadScene("HowtoPlay");



    }


    public void QuitGame(){
        
        Application.Quit();
    }
}
