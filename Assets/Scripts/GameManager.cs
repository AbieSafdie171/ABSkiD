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

    // Music Code
    /*
    private bool played1 = false;
    private bool played2 = false;
    private bool played3 = false;

    public AudioSource src1;
    public AudioSource src2;
    public AudioSource src3;

    // Abie_Safdie
    public AudioClip stellaBrown;
    public AudioClip danceNight;
    public AudioClip holdingHero;

    public AudioClip escargotBlues;

    public AudioClip missingYou;
    */



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

        hillelian = HowToPlay.getCharacter();
        
        switch(hillelian){

            case "Abie_Safdie":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Abie_Safdie.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Abie_Safdie.coolness / baseDivisor));



                // Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                // Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Daniel_Moss":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Daniel_Moss.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Daniel_Moss.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Sasha_Kaplow":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Sasha_Kaplow.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Sasha_Kaplow.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Jordan_Zicklin":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Jordan_Zicklin.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jordan_Zicklin.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Julia_Frank":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Julia_Frank.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Julia_Frank.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Jonah_Kaplan":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Jonah_Kaplan.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jonah_Kaplan.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Romie_Avivi":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Romie_Avivi.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Romie_Avivi.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Maddie_Studer":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Maddie_Studer.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Maddie_Studer.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Mady_Barth":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Mady_Barth.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Mady_Barth.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Alex_Malve":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Alex_Malve.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Alex_Malve.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Jordan_Cooper":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Jordan_Cooper.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jordan_Cooper.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Kaya_Rubinstein":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Kaya_Rubinstein.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Kaya_Rubinstein.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Lucie_Nortman":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Lucie_Nortman.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Lucie_Nortman.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Jacque_Velasco":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Jacque_Velasco.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jacque_Velasco.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Hannah_Abikzer":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Hannah_Abikzer.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Hannah_Abikzer.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Lilah_Silberman":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Lilah_Silberman.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Lilah_Silberman.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Andy_Gitelson":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Andy_Gitelson.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Andy_Gitelson.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Ella_Diamond":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Ella_Diamond.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Ella_Diamond.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Chloe_Gold":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Chloe_Gold.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Chloe_Gold.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Rabbi_Berel":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Rabbi_Berel.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Rabbi_Berel.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Bri_Tafoya":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Bri_Tafoya.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Bri_Tafoya.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Roy_Wonder":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Roy_Wonder.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Roy_Wonder.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Lucinda_Smith":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Lucinda_Smith.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Lucinda_Smith.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Rabbi_Meir":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Rabbi_Meir.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Rabbi_Meir.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Portia_Carney":
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Portia_Carney.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Portia_Carney.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
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

        /*
        if (!src1.isPlaying && played1 == false){
            src1.Play();
            played1 = true;
        } else if (!src2.isPlaying && played2 == false){
            src2.Play();
            played2 = true;
        } else {
            src3.Play();

        }

        if (played1 && played2 && played3){
            played1 = false;
            played2 = false;
            played3 = false;

        }
        */

    }
}