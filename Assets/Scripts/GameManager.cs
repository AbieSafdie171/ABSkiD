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

    public string hillelian = HowToPlay.getCharacter();

    private void Awake(){
        inst = this;
    }

    public static float getScore(){
        return score;
    }

    public static void increaseScore(int x){
        score += x;
    }

    public void setValues(){

        float baseOxygen = 1000;
        float baseHeat = 1000;
        float baseDivisor = 50;

        chosenPlayer.text = HowToPlay.getCharacter();
        
        switch(hillelian){

            case "Daniel_Moss":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Daniel_Moss.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Daniel_Moss.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                // Debug.Log("hello");
                break;
            default:
                break;


        }



    }
    // Start is called before the first frame update
    void Start()
    {
        setValues();
        score = 0;

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
