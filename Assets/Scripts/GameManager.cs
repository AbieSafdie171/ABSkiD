using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class GameManager : MonoBehaviour
{

    public HealthBar healthBar;
    public HealthBar xFactorBar;
    public FloatBar oxygenBar;
    public FloatBar heatBar;
    public GameObject onSign;

    public int currentHealth;
    public static float score;
    public float scoreLevel = 5000f;
    public float time;
    public static GameManager inst;
    public TMP_Text scoreText;
    public TMP_Text chosenPlayer;
    public string hillelian = HowToPlay.getCharacter();
    private float counter = 0.0f;
    public static int alcoholTolerance = 0;
    public GameObject astr;
    public BoxCollider person;
    public Vector3 personBaseSize = new Vector3(0.7f, 2f, 2f);
    public Vector3 carSize = new Vector3(4f, 2f, 2f);
    public Vector3 baseSize = new Vector3 (1f, 1f, 1f);
    public Vector3 smallSize = new Vector3(0.2f, 0.2f, 0.2f);
    public Vector3 skiSize = new Vector3(0.3f, 0.1f, 2f);
    public Vector3 largeSkiSize = new Vector3(0.3f, 0.1f, 4f);

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
    public AudioClip dadBod;

    // Rabbi Berel
    public AudioClip lchaimFiddler;

    // Jonah Kaplan
    public AudioClip tennesseeWhiskey;
    public AudioClip dontStopBelieving;
    public AudioClip georgia;
    public GameObject judith;

    // Romie Avivi
    public AudioClip telAviv;
    public AudioClip dancingQueen;
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

    // Lucinda Smith
    public AudioClip ghostSfx;
    public GameObject astrBody;

    // Chloe Gold
    public AudioClip tieSound;

    // Mady Barth
    public bool wildCard = false;
    public string tempName;

    // Roy Wonder
    public AudioClip ktichenNoises;

    // Sasha Kaplow
    public AudioClip rainbow;
    public GameObject rainbowObject;

    // Lilah Silberman
    public GameObject israelFlag;
    public AudioClip hatikvah;

    // Rabbi Meir
    public AudioClip shofar;
    public AudioClip yisraelHatikvah;

    // Kaya Rubinstein
    public AudioClip tickTock;

    // Jordan Cooper
    public AudioClip myLeg;

    // Andy Gitelson
    public AudioClip holdMyBeer;

    // Lucie Nortman
    public GameObject cat;
    public GameObject cuteCat;
    public GameObject cutestCat;
    public GameObject cat4;
    public GameObject cat5;
    public AudioClip aww;

    // Portia Carney
    public GameObject rack;
    public AudioClip niceRack;

    // Maddie Studer
    public AudioClip bubbles;
    public GameObject leftSki;
    public GameObject rightSki;

    // Danielle Richard
    public AudioClip baddies;
    public AudioClip muppetSong;
    public AudioClip rainbowConnections;
    public List<Material> myMaterials;
    public Color baseColor0;
    public Color baseColor1;
    public GameObject missPiggy;
    public GameObject kermitFrog;

    // Israeli Sasha
    public Material lSki;
    public Material rSki;



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
        int baseHealth = 3;
        float baseDivisor = 50;
        

        chosenPlayer.text = HowToPlay.getCharacter();

        hillelian = HowToPlay.getCharacter();
        
        switch(hillelian){

            case "Abie_Safdie":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = Abie_Safdie.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Abie_Safdie.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Abie_Safdie.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Abie_Safdie.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = endsOfTheEarth;
                src2.clip = stellaBrown;
                src3.clip = missingYou;
                break;
            case "Daniel_Moss":
                AstronautPlayer.speed = 24f;
                alcoholTolerance = Daniel_Moss.alcTol;
                xFactorBar.SetMaxHealth(3);
                xFactorBar.SetHealth(0);
                healthBar.SetMaxHealth(baseHealth + (Daniel_Moss.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Daniel_Moss.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Daniel_Moss.coolness / baseDivisor));
                src1.clip = endsOfTheEarth;
                src2.clip = endsOfTheEarth;
                src3.clip = endsOfTheEarth;
                break;
            case "Sasha_Kaplow":
                AstronautPlayer.speed = 24f;
                alcoholTolerance = Sasha_Kaplow.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Sasha_Kaplow.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Sasha_Kaplow.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Sasha_Kaplow.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(5);
                xFactorBar.SetHealth(0);
                src1.clip = telAviv;
                src2.clip = dancingQueen;
                src3.clip = telAviv;
                break;
            case "Jordan_Zicklin":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = Jordan_Zicklin.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Jordan_Zicklin.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Jordan_Zicklin.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jordan_Zicklin.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = lisztomania;
                src2.clip = endsOfTheEarth;
                src3.clip = missingYou;
                break;
            case "Julia_Frank":
                AstronautPlayer.speed = 22f;
                alcoholTolerance = Julia_Frank.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Julia_Frank.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Julia_Frank.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Julia_Frank.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = lisztomania;
                src2.clip = endsOfTheEarth;
                src3.clip = missingYou;
                break;
            case "Jonah_Kaplan":
                AstronautPlayer.speed = 23f;
                alcoholTolerance = Jonah_Kaplan.alcTol;
                xFactorBar.SetMaxHealth(5);
                xFactorBar.SetHealth(0);
                healthBar.SetMaxHealth(baseHealth + (Jonah_Kaplan.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Jonah_Kaplan.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jonah_Kaplan.coolness / baseDivisor));
                src1.clip = dontStopBelieving;
                src2.clip = tennesseeWhiskey;
                src3.clip = escargotBlues;
                break;
            case "Romie_Avivi":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = Romie_Avivi.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Romie_Avivi.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Romie_Avivi.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Romie_Avivi.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(3);
                xFactorBar.SetHealth(0);
                src1.clip = dancingQueen;
                src2.clip = telAviv;
                src3.clip = telAviv;
                break;
            case "Maddie_Studer":
                AstronautPlayer.speed = 22f;
                alcoholTolerance = Maddie_Studer.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Maddie_Studer.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Maddie_Studer.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Maddie_Studer.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(2);
                xFactorBar.SetHealth(0);
                src1.clip = dancingQueen;
                src2.clip = telAviv;
                src3.clip = telAviv;
                break;
            case "Mady_Barth":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = Mady_Barth.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Mady_Barth.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Mady_Barth.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Mady_Barth.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = lisztomania;
                src2.clip = endsOfTheEarth;
                src3.clip = missingYou;
                break;
            case "Alex_Malve":
                AstronautPlayer.speed = 22f;
                alcoholTolerance = Alex_Malve.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Alex_Malve.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Alex_Malve.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Alex_Malve.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(2);
                xFactorBar.SetHealth(0);
                src1.clip = endsOfTheEarth;
                src2.clip = endsOfTheEarth;
                src3.clip = endsOfTheEarth;
                break;
            case "Jordan_Cooper":
                AstronautPlayer.speed = 22f;
                alcoholTolerance = Jordan_Cooper.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Jordan_Cooper.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Jordan_Cooper.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jordan_Cooper.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = yisraelHatikvah;
                src2.clip = endsOfTheEarth;
                src3.clip = endsOfTheEarth;
                break;
            case "Kaya_Rubinstein":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = Kaya_Rubinstein.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Kaya_Rubinstein.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Kaya_Rubinstein.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Kaya_Rubinstein.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = yisraelHatikvah;
                src2.clip = endsOfTheEarth;
                src3.clip = endsOfTheEarth;
                break;
            case "Lucie_Nortman":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = Lucie_Nortman.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Lucie_Nortman.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Lucie_Nortman.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Lucie_Nortman.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(5);
                xFactorBar.SetHealth(0);
                src1.clip = yisraelHatikvah;
                src2.clip = endsOfTheEarth;
                src3.clip = endsOfTheEarth;
                break;
            case "Jacque_Velasco":
                AstronautPlayer.speed = 23f;
                alcoholTolerance = Jacque_Velasco.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Jacque_Velasco.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Jacque_Velasco.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jacque_Velasco.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(3);
                xFactorBar.SetHealth(0);
                src1.clip = endsOfTheEarth;
                src2.clip = endsOfTheEarth;
                src3.clip = endsOfTheEarth;
                break;
            case "Hannah_Abikzer":
                AstronautPlayer.speed = 23f;
                alcoholTolerance = Hannah_Abikzer.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Hannah_Abikzer.skiingIQ / 10));
                xFactorBar.SetMaxHealth(5);
                xFactorBar.SetHealth(0);
                oxygenBar.SetMaxHealth(baseOxygen * (Hannah_Abikzer.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Hannah_Abikzer.coolness / baseDivisor));
                src1.clip = passengers;
                src2.clip = fearForNobody;
                src3.clip = theLoneliest;
                break;
            case "Lilah_Silberman":
                AstronautPlayer.speed = 23f;
                alcoholTolerance = Lilah_Silberman.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Lilah_Silberman.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Lilah_Silberman.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Lilah_Silberman.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = escargotBlues;
                src2.clip = the505;
                src3.clip = cigaretteDaydreams;
                break;
            case "Andy_Gitelson":
                AstronautPlayer.speed = 21f;
                alcoholTolerance = Andy_Gitelson.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Andy_Gitelson.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Andy_Gitelson.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Andy_Gitelson.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(3);
                xFactorBar.SetHealth(0);
                src1.clip = umbrella;
                src2.clip = imGood;
                src3.clip = countOnMe;
                break;
            case "Ella_Diamond":
                AstronautPlayer.speed = 21f;
                alcoholTolerance = Ella_Diamond.alcTol;
                xFactorBar.SetMaxHealth(2);
                xFactorBar.SetHealth(0);
                healthBar.SetMaxHealth(baseHealth + (Ella_Diamond.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Ella_Diamond.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Ella_Diamond.coolness / baseDivisor));
                src1.clip = umbrella;
                src2.clip = imGood;
                src3.clip = countOnMe;
                break;
            case "Chloe_Gold":
                AstronautPlayer.speed = 22f;
                alcoholTolerance = Chloe_Gold.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Chloe_Gold.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Chloe_Gold.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Chloe_Gold.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(5);
                xFactorBar.SetHealth(0);
                src1.clip = endsOfTheEarth;
                src2.clip = endsOfTheEarth;
                src3.clip = endsOfTheEarth;
                break;
            case "Rabbi_Berel":
                AstronautPlayer.speed = 24f;
                alcoholTolerance = Rabbi_Berel.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Rabbi_Berel.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Rabbi_Berel.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Rabbi_Berel.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(2);
                xFactorBar.SetHealth(0);
                GroundTile.berel = true;
                src1.clip = lchaimFiddler;
                src2.clip = lchaimFiddler;
                src3.clip = lchaimFiddler;
                break;
            case "Bri_Tafoya":
                AstronautPlayer.speed = 24f;
                alcoholTolerance = Bri_Tafoya.alcTol;
                xFactorBar.SetMaxHealth(3);
                xFactorBar.SetHealth(0);
                healthBar.SetMaxHealth(baseHealth + (Bri_Tafoya.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Bri_Tafoya.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Bri_Tafoya.coolness / baseDivisor));
                src1.clip = endsOfTheEarth;
                src2.clip = endsOfTheEarth;
                src3.clip = endsOfTheEarth;
                break;
            case "Roy_Wonder":
                AstronautPlayer.speed = 24f;
                alcoholTolerance = Roy_Wonder.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Roy_Wonder.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Roy_Wonder.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Roy_Wonder.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = lisztomania;
                src2.clip = endsOfTheEarth;
                src3.clip = missingYou;
                break;
            case "Lucinda_Smith":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = Lucinda_Smith.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Lucinda_Smith.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Lucinda_Smith.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Lucinda_Smith.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = endsOfTheEarth;
                src2.clip = endsOfTheEarth;
                src3.clip = endsOfTheEarth;
                break;
            case "Rabbi_Meir":
                AstronautPlayer.speed = 24f;
                alcoholTolerance = Rabbi_Meir.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Rabbi_Meir.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Rabbi_Meir.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Rabbi_Meir.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = yisraelHatikvah;
                src2.clip = endsOfTheEarth;
                src3.clip = missingYou;
                break;
            case "Danielle_Richard":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = Danielle_Richard.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Danielle_Richard.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Danielle_Richard.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Danielle_Richard.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = muppetSong;
                src2.clip = rainbowConnections;
                src3.clip = yisraelHatikvah;
                break;
            case "Israeli_Sasha":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = 90;
                healthBar.SetMaxHealth(baseHealth + (50 / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Sasha_Kaplow.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (100 / baseDivisor));
                xFactorBar.SetMaxHealth(1);
                xFactorBar.SetHealth(0);
                myMaterials[0].color = Color.red;
                myMaterials[1].color = Color.red;
                src1.clip = telAviv;
                src2.clip = yisraelHatikvah;
                src3.clip = telAviv;
                break;
            case "Portia_Carney":
                AstronautPlayer.speed = 23f;
                alcoholTolerance = Portia_Carney.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Portia_Carney.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Portia_Carney.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Portia_Carney.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(2);
                xFactorBar.SetHealth(0);
                src1.clip = yisraelHatikvah;
                src2.clip = endsOfTheEarth;
                src3.clip = missingYou;
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

        if (wildCard){
            wildCard = false;
            hillelian = tempName;
        }
        
        switch(hillelian){
            case "Abie_Safdie":
                Abie_Safdie.xFactor();
                xFactorsrc.clip = niceBoy;
                break;
            case "Daniel_Moss":
                xFactorsrc.clip = hinneni;
                onSign.SetActive(true);
                AstronautPlayer.danielAlcohol = true;
                StartCoroutine(timer("Daniel_Moss"));
                break;
            case "Sasha_Kaplow":
                xFactorsrc.clip = rainbow;
                rainbowObject.SetActive(true);
                Sasha_Kaplow.xFactor(astr.transform.position);
                StartCoroutine(timer("Sasha_Kaplow"));
                break;
            case "Jordan_Zicklin":
                xFactorsrc.clip = dadBod;
                astr.transform.localScale += baseSize;
                onSign.SetActive(true);
                AstronautPlayer.dadBod = true;
                StartCoroutine(timer("Jordan_Zicklin"));
                break;
            case "Julia_Frank":
                Debug.Log("Julia");
                break;
            case "Jonah_Kaplan":
                xFactorsrc.clip = georgia;
                onSign.SetActive(true);
                AstronautPlayer.fran = true;
                person.size = carSize;
                judith.SetActive(true);
                StartCoroutine(timer("Jonah_Kaplan"));
                break;
            case "Romie_Avivi":
                xFactorsrc.clip = claySound;
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
                xFactorsrc.clip = bubbles;
                leftSki.transform.localScale = largeSkiSize;
                rightSki.transform.localScale = largeSkiSize;
                StartCoroutine(timer("Maddie_Studer"));
                oxygenBar.SetHealth(oxygenBar.getMaxValue());
                heatBar.SetHealth(heatBar.getMaxValue());
                break;
            case "Mady_Barth":
                tempName = Mady_Barth.xFactor();
                wildCard = true;
                getXFactor();
                break;
            case "Alex_Malve":
                xFactorsrc.clip = fireSound;
                heatBar.SetHealth(heatBar.getMaxValue());
                break;
            case "Jordan_Cooper":
                xFactorsrc.clip = myLeg;
                AstronautPlayer.speed -= 1f;
                break;
            case "Kaya_Rubinstein":
                xFactorsrc.clip = tickTock;
                AstronautPlayer.speed -= 1f;
                break;
            case "Lucie_Nortman":
                xFactorsrc.clip = aww;
                int rand = Random.Range(0, 5);

                switch (rand){
                    case 0: cat.SetActive(true);
                            break;
                    case 1: cuteCat.SetActive(true);
                            break;
                    case 2: cutestCat.SetActive(true);
                            break;
                    case 3: cat4.SetActive(true);
                            break;
                    case 4: cat5.SetActive(true);
                            break;
                }
                healthBar.SetHealth(healthBar.getMaxValue());
                heatBar.SetHealth(heatBar.getMaxValue());
                oxygenBar.SetHealth(oxygenBar.getMaxValue());
                StartCoroutine(timer("Lucie_Nortman"));
                break;
            case "Jacque_Velasco":
                xFactorsrc.clip = wow;
                onSign.SetActive(true);
                AstronautPlayer.jacquePickup = true;
                StartCoroutine(timer("Jacque_Velasco"));
                break;
            case "Hannah_Abikzer":
                xFactorsrc.clip = lonely;
                onSign.SetActive(true);
                AstronautPlayer.fran = true;
                person.size = carSize;
                fran.SetActive(true);
                StartCoroutine(timer("Hannah_Abikzer"));
                break;
            case "Lilah_Silberman":
                israelFlag.SetActive(true);
                xFactorsrc.clip = hatikvah;
                Abie_Safdie.xFactor();
                StartCoroutine(timer("Lilah_Silberman"));
                break;
            case "Andy_Gitelson":
                xFactorsrc.clip = holdMyBeer;
                Andy_Gitelson.xFactor();
                break;
            case "Ella_Diamond":
                xFactorsrc.clip = science;
                oxygenBar.SetHealth(oxygenBar.getMaxValue());
                break;
            case "Chloe_Gold":
                xFactorsrc.clip = tieSound;
                Chloe_Gold.xFactor(astr.transform.position);
                break;
            case "Rabbi_Berel":
                xFactorsrc.clip = hinneni;
                healthBar.SetHealth(healthBar.getMaxValue());
                onSign.SetActive(true);
                AstronautPlayer.danielAlcohol = true;
                StartCoroutine(timer("Daniel_Moss"));
                break;
            case "Bri_Tafoya":
                xFactorsrc.clip = fallingInLove;
                heatBar.SetHealth(heatBar.getMaxValue());
                healthBar.SetHealth(healthBar.getMaxValue());
                break;
            case "Roy_Wonder":
                xFactorsrc.clip = ktichenNoises;
                Roy_Wonder.xFactor(astr.transform.position);
                break;
            case "Lucinda_Smith":
                xFactorsrc.clip = ghostSfx;
                onSign.SetActive(true);
                astrBody.SetActive(false);
                AstronautPlayer.ghoster = true;
                StartCoroutine(timer("Lucinda_Smith"));
                break;
            case "Rabbi_Meir":
                xFactorsrc.clip = shofar;
                astr.transform.localScale = smallSize;
                onSign.SetActive(true);
                StartCoroutine(timer("Rabbi_Meir"));
                break;
            case "Danielle_Richard":
                xFactorsrc.clip = baddies;
                israelFlag.SetActive(true);
                Abie_Safdie.xFactor();
                myMaterials[0].color = Color.green;
                myMaterials[1].color = Color.green;
                missPiggy.SetActive(true);
                kermitFrog.SetActive(true);
                StartCoroutine(timer("Danielle_Richard"));
                break;
            case "Israeli_Sasha":
                break;
            case "Portia_Carney":
                rack.SetActive(true);
                xFactorsrc.clip = niceRack;
                healthBar.SetHealth(healthBar.getMaxValue());
                StartCoroutine(timer("Portia_Carney"));
                break;
            default:
                break;


        }



    }
    // Start is called before the first frame update
    void Start()
    {
        myMaterials = astrBody.GetComponent<Renderer>().materials.ToList();
        baseColor0 = myMaterials[0].color;
        baseColor1 = myMaterials[1].color;
        missPiggy.SetActive(false);
        kermitFrog.SetActive(false);
        rack.SetActive(false);
        fran.SetActive(false);
        cat.SetActive(false);
        cuteCat.SetActive(false);
        cutestCat.SetActive(false);
        cat4.SetActive(false);
        cat5.SetActive(false);
        judith.SetActive(false);
        onSign.SetActive(false);
        rainbowObject.SetActive(false);
        israelFlag.SetActive(false);
        GroundTile.berel = false;
        AstronautPlayer.speed = 25f;
        setValues();
        score = 0;

    }

    public IEnumerator timer(string p){

        float elapsed = 0.0f;
        float duration = 15.0f;

          while (elapsed < duration){

            elapsed += Time.deltaTime;

            if (elapsed > 13f)
                onSign.SetActive(false);
            
            yield return null;
          }
          
        switch(p){

            case "Daniel_Moss":
                    AstronautPlayer.danielAlcohol = false;
                    break;
            case "Hannah_Abikzer":
                    fran.SetActive(false);
                    person.size = personBaseSize;
                    AstronautPlayer.fran = false;
                    break;
            case "Jonah_Kaplan":
                    judith.SetActive(false);
                    person.size = personBaseSize;
                    AstronautPlayer.fran = false;
                    break;
            case "Jacque_Velasco":
                    AstronautPlayer.jacquePickup = false;
                    break;
            case "Jordan_Zicklin":
                    AstronautPlayer.dadBod = false;
                    astr.transform.localScale = baseSize;
                    break;
            case "Lucinda_Smith":
                    astrBody.SetActive(true);
                    AstronautPlayer.ghoster = false;
                    break;
            case "Sasha_Kaplow":
                    rainbowObject.SetActive(false);
                    break;
            case "Lilah_Silberman":
                    israelFlag.SetActive(false);
                    break;
            case "Rabbi_Meir":
                    astr.transform.localScale = baseSize;
                    break;
            case "Lucie_Nortman":
                    cuteCat.SetActive(false);
                    cutestCat.SetActive(false);
                    cat.SetActive(false);
                    cat4.SetActive(false);
                    cat5.SetActive(false);
                    break;
            case "Portia_Carney":
                    rack.SetActive(false);
                    break;
            case "Maddie_Studer":
                    leftSki.transform.localScale = skiSize;
                    rightSki.transform.localScale = skiSize;
                    break;
            case "Danielle_Richard":
                    israelFlag.SetActive(false);
                    myMaterials[0].color = baseColor0;
                    myMaterials[1].color = baseColor1;
                    missPiggy.SetActive(false);
                    kermitFrog.SetActive(false);
                    break;
            case "Israeli_Sasha":
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

        if (score >= scoreLevel){
            AstronautPlayer.speed += 2;
            // Debug.Log(AstronautPlayer.speed);
            scoreLevel += 5000f;
        }

        scoreText.text = "SCORE: " + score;


        if (Input.GetKeyDown("space"))
        {
            int max = xFactorBar.getMaxValue();
            int cur = xFactorBar.GetCurrentHealth();
            if(cur == max){
                getXFactor();
                xFactorsrc.Play();
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