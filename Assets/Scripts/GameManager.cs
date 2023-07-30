using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public HealthBar healthBar;
    public HealthBar xFactorBar;
    public FloatBar oxygenBar;
    public FloatBar heatBar;
    public GameObject onSign;

    public int currentHealth;

    public static float score;

    public float time;

    public static GameManager inst;

    public TMP_Text scoreText;

    public TMP_Text chosenPlayer;

    public string hillelian = HowToPlay.getCharacter();

    private float counter = 0.0f;

    public static int alcoholTolerance = 0;

    // Music Code
    
    private bool played1 = false;
    private bool played2 = false;
    private bool played3 = false;

    public AudioSource src1;
    public AudioSource src2;
    public AudioSource src3;

    public AudioSource xFactorsrc;

    // Abie_Safdie
    public AudioClip endsOfTheEarth;
    public AudioClip stellaBrown;
    public AudioClip missingYou;
    public AudioClip niceBoy;

    // Up for Grabs!
    public AudioClip danceNight;
    public AudioClip holdingHero;
    public AudioClip danceWithSomebody;

    // Lilah Silberman
    public AudioClip escargotBlues;
    public AudioClip the505;
    public AudioClip cigaretteDaydreams;

    // Hannah Abikzer
    public AudioClip theLoneliest;
    public AudioClip fearForNobody;
    public AudioClip passengers;
    public AudioClip lonely;
    public GameObject fran;

    // Jordan Zicklin
    public AudioClip lisztomania;

    // Rabbi Berel
    public AudioClip lchaimFiddler;

    // Jonah Kaplan
    public AudioClip tennesseeWhiskey;
    public AudioClip dontStopBelieving;
    public AudioClip georgia;
    public GameObject judith;

    // Romie Avivi
    public AudioClip telAviv;
    public AudioClip claySound;

    // Alex Malve
    public AudioClip fireSound;

    // Ella Diamond
    public AudioClip umbrella;
    public AudioClip imGood;
    public AudioClip countOnMe;
    public AudioClip science;

    // Bri Tafoya
    public AudioClip fallingInLove;

    // Daniel Moss
    public AudioClip hinneni;

    // Jacque Velasco
    public AudioClip wow;
    



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
                alcoholTolerance = Abie_Safdie.alcTol;
                healthBar.SetMaxHealth(5);
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                oxygenBar.SetMaxHealth(baseOxygen * (Abie_Safdie.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Abie_Safdie.coolness / baseDivisor));
                src1.clip = stellaBrown;
                src2.clip = endsOfTheEarth;
                src3.clip = missingYou;
                xFactorsrc.clip = niceBoy;
                break;
            case "Daniel_Moss":
                alcoholTolerance = Daniel_Moss.alcTol;
                xFactorBar.SetMaxHealth(3);
                xFactorBar.SetHealth(0);
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Daniel_Moss.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Daniel_Moss.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                src1.clip = endsOfTheEarth;
                src2.clip = endsOfTheEarth;
                src3.clip = endsOfTheEarth;
                xFactorsrc.clip = hinneni;
                break;
            case "Sasha_Kaplow":
                alcoholTolerance = Sasha_Kaplow.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Sasha_Kaplow.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Sasha_Kaplow.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Jordan_Zicklin":
                alcoholTolerance = Jordan_Zicklin.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Jordan_Zicklin.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jordan_Zicklin.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Julia_Frank":
                alcoholTolerance = Julia_Frank.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Julia_Frank.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Julia_Frank.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Jonah_Kaplan":
                alcoholTolerance = Jonah_Kaplan.alcTol;
                xFactorBar.SetMaxHealth(5);
                xFactorBar.SetHealth(0);
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Jonah_Kaplan.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jonah_Kaplan.coolness / baseDivisor));
                src1.clip = dontStopBelieving;
                src2.clip = tennesseeWhiskey;
                src3.clip = escargotBlues;
                xFactorsrc.clip = georgia;
                break;
            case "Romie_Avivi":
                alcoholTolerance = Romie_Avivi.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Romie_Avivi.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Romie_Avivi.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(3);
                xFactorBar.SetHealth(0);
                src1.clip = telAviv;
                src2.clip = telAviv;
                src3.clip = telAviv;
                xFactorsrc.clip = claySound;
                break;
            case "Maddie_Studer":
                alcoholTolerance = Maddie_Studer.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Maddie_Studer.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Maddie_Studer.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Mady_Barth":
                alcoholTolerance = Mady_Barth.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Mady_Barth.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Mady_Barth.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Alex_Malve":
                alcoholTolerance = Alex_Malve.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Alex_Malve.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Alex_Malve.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(2);
                xFactorBar.SetHealth(0);
                src1.clip = endsOfTheEarth;
                src2.clip = endsOfTheEarth;
                src3.clip = endsOfTheEarth;
                xFactorsrc.clip = fireSound;
                break;
            case "Jordan_Cooper":
                alcoholTolerance = Jordan_Cooper.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Jordan_Cooper.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jordan_Cooper.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Kaya_Rubinstein":
                alcoholTolerance = Kaya_Rubinstein.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Kaya_Rubinstein.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Kaya_Rubinstein.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Lucie_Nortman":
                alcoholTolerance = Lucie_Nortman.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Lucie_Nortman.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Lucie_Nortman.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Jacque_Velasco":
                alcoholTolerance = Jacque_Velasco.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Jacque_Velasco.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jacque_Velasco.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(3);
                xFactorBar.SetHealth(0);
                src1.clip = endsOfTheEarth;
                src2.clip = endsOfTheEarth;
                src3.clip = endsOfTheEarth;
                xFactorsrc.clip = wow;
                break;
            case "Hannah_Abikzer":
                alcoholTolerance = Hannah_Abikzer.alcTol;
                healthBar.SetMaxHealth(5);
                xFactorBar.SetMaxHealth(5);
                xFactorBar.SetHealth(0);
                oxygenBar.SetMaxHealth(baseOxygen * (Hannah_Abikzer.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Hannah_Abikzer.coolness / baseDivisor));
                src1.clip = passengers;
                src2.clip = fearForNobody;
                src3.clip = theLoneliest;
                xFactorsrc.clip = lonely;
                break;
            case "Lilah_Silberman":
                alcoholTolerance = Lilah_Silberman.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Lilah_Silberman.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Lilah_Silberman.coolness / baseDivisor));
                src1.clip = escargotBlues;
                src2.clip = the505;
                src3.clip = cigaretteDaydreams;
                break;
            case "Andy_Gitelson":
                alcoholTolerance = Andy_Gitelson.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Andy_Gitelson.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Andy_Gitelson.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Ella_Diamond":
                alcoholTolerance = Ella_Diamond.alcTol;
                xFactorBar.SetMaxHealth(2);
                xFactorBar.SetHealth(0);
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Ella_Diamond.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Ella_Diamond.coolness / baseDivisor));
                src1.clip = umbrella;
                src2.clip = imGood;
                src3.clip = countOnMe;
                xFactorsrc.clip = science;
                break;
            case "Chloe_Gold":
                alcoholTolerance = Chloe_Gold.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Chloe_Gold.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Chloe_Gold.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Rabbi_Berel":
                alcoholTolerance = Rabbi_Berel.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Rabbi_Berel.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Rabbi_Berel.coolness / baseDivisor));
                src1.clip = lchaimFiddler;
                src2.clip = lchaimFiddler;
                src3.clip = lchaimFiddler;
                break;
            case "Bri_Tafoya":
                alcoholTolerance = Bri_Tafoya.alcTol;
                xFactorBar.SetMaxHealth(3);
                xFactorBar.SetHealth(0);
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Bri_Tafoya.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Bri_Tafoya.coolness / baseDivisor));
                src1.clip = endsOfTheEarth;
                src2.clip = endsOfTheEarth;
                src3.clip = endsOfTheEarth;
                xFactorsrc.clip = fallingInLove;
                break;
            case "Roy_Wonder":
                alcoholTolerance = Roy_Wonder.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Roy_Wonder.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Roy_Wonder.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Lucinda_Smith":
                alcoholTolerance = Lucinda_Smith.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Lucinda_Smith.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Lucinda_Smith.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Rabbi_Meir":
                alcoholTolerance = Rabbi_Meir.alcTol;
                healthBar.SetMaxHealth(5);
                oxygenBar.SetMaxHealth(baseOxygen * (Rabbi_Meir.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Rabbi_Meir.coolness / baseDivisor));
                Debug.Log("Oxygen: " + oxygenBar.GetCurrentHealth());
                Debug.Log("Heat: " + heatBar.GetCurrentHealth());
                break;
            case "Portia_Carney":
                alcoholTolerance = Portia_Carney.alcTol;
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


    public void getXFactor(){

        hillelian = HowToPlay.getCharacter();

        currentHealth = healthBar.GetCurrentHealth();
        float xOxygen = oxygenBar.GetCurrentHealth();
        float xHeat = heatBar.GetCurrentHealth();
        
        switch(hillelian){
            case "Abie_Safdie":
                Abie_Safdie.xFactor();
                break;
            case "Daniel_Moss":
                onSign.SetActive(true);
                AstronautPlayer.danielAlcohol = true;
                StartCoroutine(timer("Daniel_Moss"));
                break;
            case "Sasha_Kaplow":
                break;
            case "Jordan_Zicklin":
                break;
            case "Julia_Frank":
                break;
            case "Jonah_Kaplan":
                onSign.SetActive(true);
                AstronautPlayer.fran = true;
                judith.SetActive(true);
                StartCoroutine(timer("Jonah_Kaplan"));
                break;
            case "Romie_Avivi":
                float pOx = xOxygen / oxygenBar.getMaxValue();
                float pHeat = xHeat / heatBar.getMaxValue();
                float pHealth = currentHealth / healthBar.getMaxValue();
                if (pHealth <= pOx && pHealth <= pHeat){
                    healthBar.SetHealth(healthBar.getMaxValue());
                } else if(pOx < pHealth && pOx < pHeat){
                    oxygenBar.SetHealth(oxygenBar.getMaxValue());
                } else {
                    heatBar.SetHealth(heatBar.getMaxValue());
                }
                break;
            case "Maddie_Studer":
                break;
            case "Mady_Barth":
                break;
            case "Alex_Malve":
                heatBar.SetHealth(heatBar.getMaxValue());
                break;
            case "Jordan_Cooper":
                break;
            case "Kaya_Rubinstein":
                break;
            case "Lucie_Nortman":
                break;
            case "Jacque_Velasco":
                onSign.SetActive(true);
                AstronautPlayer.jacquePickup = true;
                StartCoroutine(timer("Jacque_Velasco"));
                break;
            case "Hannah_Abikzer":
                onSign.SetActive(true);
                AstronautPlayer.fran = true;
                fran.SetActive(true);
                StartCoroutine(timer("Hannah_Abikzer"));
                break;
            case "Lilah_Silberman":
                break;
            case "Andy_Gitelson":
                break;
            case "Ella_Diamond":
                oxygenBar.SetHealth(oxygenBar.getMaxValue());
                break;
            case "Chloe_Gold":
                break;
            case "Rabbi_Berel":
                break;
            case "Bri_Tafoya":
                heatBar.SetHealth(heatBar.getMaxValue());
                healthBar.SetHealth(healthBar.getMaxValue());
                break;
            case "Roy_Wonder":
                break;
            case "Lucinda_Smith":
                break;
            case "Rabbi_Meir":
                break;
            case "Portia_Carney":
                break;
            default:
                break;


        }



    }
    // Start is called before the first frame update
    void Start()
    {
        fran.SetActive(false);
        judith.SetActive(false);
        onSign.SetActive(false);
        setValues();
        score = 0;

    }

    public IEnumerator timer(string p){

        float elapsed = 0.0f;
        float duration = 15.0f;

          while (elapsed < duration){

            elapsed += Time.deltaTime;
            
            yield return null;
          }
          
        switch(p){

            case "Daniel_Moss":
                    AstronautPlayer.danielAlcohol = false;
                    onSign.SetActive(false);
                    break;
            case "Hannah_Abikzer":
                    fran.SetActive(false);
                    onSign.SetActive(false);
                    AstronautPlayer.fran = false;
                    break;
            case "Jonah_Kaplan":
                    onSign.SetActive(false);
                    judith.SetActive(false);
                    AstronautPlayer.fran = false;
                    break;
            case "Jacque_Velasco":
                    AstronautPlayer.jacquePickup = false;
                    onSign.SetActive(false);
                    break;
            default:
                break;

        }

    }







    // Update is called once per frame
    void Update()
    {
        
        float currentOxygen = oxygenBar.GetCurrentHealth();

        currentOxygen -= (59 * Time.deltaTime);

        Debug.Log(currentOxygen);

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

        counter += Time.deltaTime;

        score += time;

        score = Mathf.Round(score);

        scoreText.text = "SCORE: " + score;


        if (Input.GetKeyDown("space"))
        {
            int max = xFactorBar.getMaxValue();
            int cur = xFactorBar.GetCurrentHealth();
            if(cur == max){
                xFactorsrc.Play();
                getXFactor();
                xFactorBar.SetHealth(0);
            } 
        }

        
        if (!src1.isPlaying && !played1 && !src3.isPlaying){
            src1.Play();
            played1 = true;
        } else if (!src1.isPlaying && !src2.isPlaying && !played2 && played1){
            src2.Play();
            played2 = true;
        } else if (!src1.isPlaying && !src2.isPlaying && !src3.isPlaying && played2 && played1){
            src3.Play();
            played3 = true;
        }

        if (played1 && played2 && played3){
            played1 = false;
            played2 = false;
            played3 = false;
        }
        

    }
}