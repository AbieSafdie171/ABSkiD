using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DeathScreen : MonoBehaviour
{

    public TMP_Text deathScore;



    // Start is called before the first frame update
    void Start()
    {
        deathScore.text = "SCORE: " + GameManager.getScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
