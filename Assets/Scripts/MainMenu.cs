using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void CharacterSelect(){

        SceneManager.LoadScene("Abie_Safdie");

    }

    public void HowToPlay(){


            SceneManager.LoadScene("HowtoPlay");



    }


    public void QuitGame(){
        Application.Quit();
    }
}
