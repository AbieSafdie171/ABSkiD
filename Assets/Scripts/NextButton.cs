using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{
    
    public void NButton(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void PrevButton(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
    
}
