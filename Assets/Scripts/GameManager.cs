using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public HealthBar healthBar;

    public FloatBar oxygenBar;

    public FloatBar heatBar;

    public int currentHealth;

    public static float score;

    public float time;

    public static GameManager inst;

    public TMP_Text scoreText;

    public TMP_Text chosenPlayer;

    public static float getScore(){
        return score;
    }

    public static void increaseScore(int x){
        score += x;
    }

    private void Awake(){
        inst = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        // currentHealth = 5;
        healthBar.SetMaxHealth(5);
        oxygenBar.SetMaxHealth(1000);
        heatBar.SetMaxHealth(1000);
        score = 0;

        chosenPlayer.text = HowToPlay.getCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
        float currentOxygen = oxygenBar.GetCurrentHealth();

        currentOxygen -= (59 * Time.deltaTime);

        oxygenBar.SetHealth(currentOxygen);

        if (oxygenBar.GetCurrentHealth() == 0){
				SceneManager.LoadScene("OxygenDeath");
			}

        float currentHeat = heatBar.GetCurrentHealth();

        currentHeat -= (59 * Time.deltaTime);

        heatBar.SetHealth(currentHeat);

        if (heatBar.GetCurrentHealth() == 0){
				SceneManager.LoadScene("ColdDeath");
			}

        time = (Time.deltaTime * 100);

        score += time;

        score = Mathf.Round(score);

        scoreText.text = "SCORE: " + score;


    }
}
