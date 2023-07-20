using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{

    public AudioSource src;

    public static string chosenChar;

    public void Start(){
        Scene currentScene = SceneManager.GetActiveScene();
        // Debug.Log(currentScene.name);
        chosenChar = currentScene.name;
    }

    public void PlayEffect(){

        src.time = 1.05f;
        src.Play();        

    }

    public void BackButton (){
        
        PlayEffect();
        SceneManager.LoadScene("MainMenu");


    }
    
    public static string getCharacter(){
        return chosenChar;
    }
    
    public void PlayButton(){
        PlayEffect();
        SceneManager.LoadScene("SkiScene");
    }
}
