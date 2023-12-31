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
    public float timeValue;
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
    
    private bool played1 = false;
    private bool played2 = false;
    private bool played3 = false;

    public bool fixBars = false;

    public AudioSource src1;
    public AudioSource src2;
    public AudioSource src3;

    public AudioSource xFactorsrc;

    // Abie_Safdie
    public AudioClip endsOfTheEarth;
    public AudioClip stellaBrown;
    public AudioClip missingYou;
    public AudioClip niceBoy;
    public GameObject njb;
    public GameObject girl;
    public GameObject redHeart;

    // Up for Grabs!
    public AudioClip danceNight;
    public AudioClip holdingHero;
    public AudioClip danceWithSomebody;
    public AudioClip paradise;
    public AudioClip surfinUSA;

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
    public AudioClip dontStopBelieving;
    public AudioClip georgia;
    public GameObject judith;

    // Julia Frank
    public AudioClip happyTrails;
    public AudioClip wayToGo;
    public GameObject bat;
    public GameObject soccer1;
    public GameObject soccer2;

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
    public AudioClip californiaGirls;
    public string tempName;

    // Roy Wonder
    public AudioClip ktichenNoises;

    // Sasha Kaplow
    public AudioClip rainbow;
    public GameObject rainbowObject;
    public AudioClip heather;

    // Lilah Silberman
    public GameObject israelFlag;
    public GameObject flower1;
    public GameObject flower2;
    public GameObject flower3;
    public GameObject flower4;
    public AudioClip hatikvah;

    // Rabbi Meir
    public AudioClip shofar;
    public AudioClip yisraelHatikvah;
    public AudioClip osehShalom;

    // Kaya Rubinstein
    public AudioClip tickTock;

    // Jordan Cooper
    public AudioClip myLeg;

    // Andy Gitelson
    public AudioClip holdMyBeer;
    public AudioClip comingHome;

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
    public AudioClip feeling22;

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
    public AudioClip smallTelAviv;
    public AudioClip oldStory;
    public AudioClip omerAdam;
    public GameObject palmTree;
    public GameObject beachUmbrella;
    public GameObject beachChair;
    public GameObject beachBoard;
    public GameObject beachBucket;
    public Quaternion r = Quaternion.identity;
    public Quaternion q = Quaternion.identity;

    // Ollie Goldstein
    public AudioClip somewhereRainbow;

    // Analise Levy
    public AudioClip shortRocky;
    public AudioClip rockyMountainHigh;
    public AudioClip coastline;
    public GameObject mountain;

    // Adeline Ellison
    public AudioClip mammaMia;
    public bool toxicMan = false;
    public GameObject greece;
    public GameObject man1;
    public Quaternion m = Quaternion.identity;

    // Ido Katz
    public AudioClip slay;
    public GameObject sword;

    // Nathan Maryanov
    public AudioClip smoke;
    public GameObject smokeParticle;

    // Tomer
    public GameObject gun1;
    public GameObject gun2;
    public GameObject usaFlag;
    public GameObject israelFlag2;
    public AudioClip bornUSA;

    // Emma Healy
    public AudioClip ucla;
    public GameObject bear1;
    public GameObject bear2;
    public GameObject bear3;
    public GameObject bear4;
    public GameObject bear5;




    private void Awake(){
        inst = this;
    }

    public static float getScore(){
        return Mathf.Round(score);
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
                src1.clip = stellaBrown;
                src2.clip = endsOfTheEarth;
                src3.clip = paradise;
                break;
            case "Daniel_Moss":
                AstronautPlayer.speed = 24f;
                alcoholTolerance = Daniel_Moss.alcTol;
                xFactorBar.SetMaxHealth(3);
                xFactorBar.SetHealth(0);
                healthBar.SetMaxHealth(baseHealth + (Daniel_Moss.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Daniel_Moss.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Daniel_Moss.coolness / baseDivisor));
                src1.clip = telAviv;
                src2.clip = theLoneliest;
                src3.clip = surfinUSA;
                break;
            case "Sasha_Kaplow":
                AstronautPlayer.speed = 24f;
                alcoholTolerance = Sasha_Kaplow.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Sasha_Kaplow.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Sasha_Kaplow.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Sasha_Kaplow.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(6);
                xFactorBar.SetHealth(0);
                src1.clip = heather;
                src2.clip = cigaretteDaydreams;
                src3.clip = fearForNobody;
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
                src2.clip = rockyMountainHigh;
                src3.clip = holdingHero;
                break;
            case "Julia_Frank":
                AstronautPlayer.speed = 22f;
                AstronautPlayer.danielAlcohol = true;
                alcoholTolerance = Julia_Frank.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Julia_Frank.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Julia_Frank.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Julia_Frank.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = happyTrails;
                src2.clip = happyTrails;
                src3.clip = happyTrails;
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
                src2.clip = passengers;
                src3.clip = danceNight;
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
                src2.clip = danceNight;
                src3.clip = danceWithSomebody;
                break;
            case "Maddie_Studer":
                AstronautPlayer.speed = 22f;
                alcoholTolerance = Maddie_Studer.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Maddie_Studer.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Maddie_Studer.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Maddie_Studer.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(2);
                xFactorBar.SetHealth(0);
                src1.clip = danceWithSomebody;
                src2.clip = dancingQueen;
                src3.clip = danceNight;
                break;
            case "Mady_Barth":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = Mady_Barth.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Mady_Barth.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Mady_Barth.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Mady_Barth.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = imGood;
                src2.clip = californiaGirls;
                src3.clip = umbrella;
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
                src2.clip = missingYou;
                src3.clip = coastline;
                break;
            case "Jordan_Cooper":
                AstronautPlayer.speed = 22f;
                alcoholTolerance = Jordan_Cooper.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Jordan_Cooper.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Jordan_Cooper.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jordan_Cooper.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(11);
                xFactorBar.SetHealth(0);
                src1.clip = dontStopBelieving;
                src2.clip = the505;
                src3.clip = lisztomania;
                break;
            case "Kaya_Rubinstein":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = Kaya_Rubinstein.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Kaya_Rubinstein.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Kaya_Rubinstein.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Kaya_Rubinstein.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = oldStory;
                src2.clip = telAviv;
                src3.clip = cigaretteDaydreams;
                break;
            case "Lucie_Nortman":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = Lucie_Nortman.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Lucie_Nortman.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Lucie_Nortman.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Lucie_Nortman.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(5);
                xFactorBar.SetHealth(0);
                src1.clip = paradise;
                src2.clip = endsOfTheEarth;
                src3.clip = heather;
                break;
            case "Jacque_Velasco":
                AstronautPlayer.speed = 23f;
                alcoholTolerance = Jacque_Velasco.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Jacque_Velasco.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Jacque_Velasco.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Jacque_Velasco.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(3);
                xFactorBar.SetHealth(0);
                src1.clip = rockyMountainHigh;
                src2.clip = the505;
                src3.clip = passengers;
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
                src1.clip = comingHome;
                src2.clip = surfinUSA;
                src3.clip = dontStopBelieving;
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
                src1.clip = heather;
                src2.clip = escargotBlues;
                src3.clip = cigaretteDaydreams;
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
                src1.clip = californiaGirls;
                src2.clip = danceNight;
                src3.clip = surfinUSA;
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
                src2.clip = dontStopBelieving;
                src3.clip = rainbowConnections;
                break;
            case "Lucinda_Smith":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = Lucinda_Smith.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Lucinda_Smith.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Lucinda_Smith.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Lucinda_Smith.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = the505;
                src2.clip = countOnMe;
                src3.clip = comingHome;
                break;
            case "Rabbi_Meir":
                AstronautPlayer.speed = 24f;
                alcoholTolerance = Rabbi_Meir.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Rabbi_Meir.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Rabbi_Meir.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Rabbi_Meir.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(3);
                xFactorBar.SetHealth(0);
                src1.clip = osehShalom;
                src2.clip = yisraelHatikvah;
                src3.clip = oldStory;
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
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                myMaterials[0].color = Color.black;
                myMaterials[1].color = Color.red;
                src1.clip = oldStory;
                src2.clip = telAviv;
                src3.clip = omerAdam;
                break;
            case "Ollie_Goldstein":
                AstronautPlayer.speed = 23f;
                alcoholTolerance = Ollie_Goldstein.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Ollie_Goldstein.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Ollie_Goldstein.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Ollie_Goldstein.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(3);
                xFactorBar.SetHealth(0);
                src1.clip = danceWithSomebody;
                src2.clip = rainbowConnections;
                src3.clip = endsOfTheEarth;
                break;
            case "Analise_Levy":
                AstronautPlayer.speed = 23f;
                alcoholTolerance = Analise_Levy.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Analise_Levy.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Analise_Levy.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Analise_Levy.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = coastline;
                src2.clip = rockyMountainHigh;
                src3.clip = endsOfTheEarth;
                break;
            case "Adeline_Ellison":
                AstronautPlayer.speed = 23f;
                alcoholTolerance = Adeline_Ellison.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Adeline_Ellison.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Adeline_Ellison.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Adeline_Ellison.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = dancingQueen;
                src2.clip = feeling22;
                src3.clip = passengers;
                break;
            case "Ido_Katz":
                AstronautPlayer.speed = 23f;
                alcoholTolerance = Ido_Katz.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Ido_Katz.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Ido_Katz.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Ido_Katz.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = omerAdam;
                src2.clip = oldStory;
                src3.clip = yisraelHatikvah;
                break;
            case "Nathan_Maryanov":
                AstronautPlayer.speed = 22f;
                alcoholTolerance = Nathan_Maryanov.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Nathan_Maryanov.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Nathan_Maryanov.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Nathan_Maryanov.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(2);
                xFactorBar.SetHealth(0);
                src1.clip = imGood;
                src2.clip = californiaGirls;
                src3.clip = rockyMountainHigh;
                break;
            case "Tomer":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = Kaya_Rubinstein.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Kaya_Rubinstein.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Kaya_Rubinstein.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Kaya_Rubinstein.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(5);
                xFactorBar.SetHealth(0);
                src1.clip = yisraelHatikvah;
                src2.clip = oldStory;
                src3.clip = omerAdam;
                break;
            case "Emma_Healy":
                AstronautPlayer.speed = 25f;
                alcoholTolerance = 60;
                healthBar.SetMaxHealth(baseHealth + (60 / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (85 / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (70 / baseDivisor));
                xFactorBar.SetMaxHealth(4);
                xFactorBar.SetHealth(0);
                src1.clip = coastline;
                src2.clip = feeling22;
                src3.clip = passengers;
                break;
            case "Portia_Carney":
                AstronautPlayer.speed = 23f;
                alcoholTolerance = Portia_Carney.alcTol;
                healthBar.SetMaxHealth(baseHealth + (Portia_Carney.skiingIQ / 10));
                oxygenBar.SetMaxHealth(baseOxygen * (Portia_Carney.stamina / baseDivisor));
                heatBar.SetMaxHealth(baseHeat * (Portia_Carney.coolness / baseDivisor));
                xFactorBar.SetMaxHealth(2);
                xFactorBar.SetHealth(0);
                src1.clip = feeling22;
                src2.clip = countOnMe;
                src3.clip = passengers;
                break;
            default:
                break;
        }
    }


    public void getXFactor(){

        hillelian = HowToPlay.getCharacter();

        fixBars = true;

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
                girls();
                njb.SetActive(true);
                StartCoroutine(timer("Abie_Safdie", 8f));
                break;
            case "Daniel_Moss":
                xFactorsrc.clip = hinneni;
                onSign.SetActive(true);
                AstronautPlayer.danielAlcohol = true;
                StartCoroutine(timer("Daniel_Moss", 15f));
                break;
            case "Sasha_Kaplow":
                xFactorsrc.clip = rainbow;
                rainbowObject.SetActive(true);
                Sasha_Kaplow.xFactor(astr.transform.position);
                StartCoroutine(timer("Sasha_Kaplow", 6f));
                break;
            case "Jordan_Zicklin":
                xFactorsrc.clip = dadBod;
                astr.transform.localScale += baseSize;
                onSign.SetActive(true);
                AstronautPlayer.dadBod = true;
                StartCoroutine(timer("Jordan_Zicklin", 15f));
                break;
            case "Julia_Frank":
                xFactorsrc.clip = wayToGo;
                healthBar.SetHealth(healthBar.getMaxValue());
                heatBar.SetHealth(heatBar.getMaxValue());
                oxygenBar.SetHealth(oxygenBar.getMaxValue());
                bat.SetActive(true);
                soccer1.SetActive(true);
                soccer2.SetActive(true);
                StartCoroutine(timer("Julia_Frank", 6f));
                break;
            case "Jonah_Kaplan":
                xFactorsrc.clip = georgia;
                onSign.SetActive(true);
                AstronautPlayer.fran = true;
                person.size = carSize;
                judith.SetActive(true);
                StartCoroutine(timer("Jonah_Kaplan", 15f));
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
                fixBars = false;
                break;
            case "Maddie_Studer":
                xFactorsrc.clip = bubbles;
                leftSki.transform.localScale = largeSkiSize;
                rightSki.transform.localScale = largeSkiSize;
                oxygenBar.SetHealth(oxygenBar.getMaxValue());
                heatBar.SetHealth(heatBar.getMaxValue());
                StartCoroutine(timer("Maddie_Studer", 10f));
                break;
            case "Mady_Barth":
                tempName = Mady_Barth.xFactor();
                wildCard = true;
                getXFactor();
                break;
            case "Alex_Malve":
                xFactorsrc.clip = fireSound;
                heatBar.SetHealth(heatBar.getMaxValue());
                fixBars = false;
                break;
            case "Jordan_Cooper":
                xFactorsrc.clip = myLeg;
                AstronautPlayer.speed -= 3f;
                fixBars = false;
                break;
            case "Kaya_Rubinstein":
                xFactorsrc.clip = tickTock;
                AstronautPlayer.speed -= 1f;
                fixBars = false;
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
                StartCoroutine(timer("Lucie_Nortman", 7f));
                break;
            case "Jacque_Velasco":
                xFactorsrc.clip = wow;
                onSign.SetActive(true);
                AstronautPlayer.jacquePickup = true;
                StartCoroutine(timer("Jacque_Velasco", 10f));
                break;
            case "Hannah_Abikzer":
                xFactorsrc.clip = lonely;
                onSign.SetActive(true);
                AstronautPlayer.fran = true;
                person.size = carSize;
                fran.SetActive(true);
                StartCoroutine(timer("Hannah_Abikzer", 15f));
                break;
            case "Lilah_Silberman":
                israelFlag.SetActive(true);
                xFactorsrc.clip = hatikvah;
                Abie_Safdie.xFactor();
                flowers();
                StartCoroutine(timer("Lilah_Silberman", 8f));
                break;
            case "Andy_Gitelson":
                xFactorsrc.clip = holdMyBeer;
                Andy_Gitelson.xFactor();
                fixBars = false;
                break;
            case "Ella_Diamond":
                xFactorsrc.clip = science;
                oxygenBar.SetHealth(oxygenBar.getMaxValue());
                fixBars = false;
                break;
            case "Chloe_Gold":
                xFactorsrc.clip = tieSound;
                Chloe_Gold.xFactor(astr.transform.position);
                fixBars = false;
                break;
            case "Rabbi_Berel":
                xFactorsrc.clip = hinneni;
                healthBar.SetHealth(healthBar.getMaxValue());
                onSign.SetActive(true);
                AstronautPlayer.danielAlcohol = true;
                StartCoroutine(timer("Daniel_Moss", 15f));
                break;
            case "Bri_Tafoya":
                xFactorsrc.clip = fallingInLove;
                heatBar.SetHealth(heatBar.getMaxValue());
                healthBar.SetHealth(healthBar.getMaxValue());
                fixBars = false;
                break;
            case "Roy_Wonder":
                xFactorsrc.clip = ktichenNoises;
                Roy_Wonder.xFactor(astr.transform.position);
                fixBars = false;
                break;
            case "Lucinda_Smith":
                xFactorsrc.clip = ghostSfx;
                onSign.SetActive(true);
                astrBody.SetActive(false);
                AstronautPlayer.ghoster = true;
                StartCoroutine(timer("Lucinda_Smith", 13f));
                break;
            case "Rabbi_Meir":
                xFactorsrc.clip = shofar;
                astr.transform.localScale = smallSize;
                onSign.SetActive(true);
                StartCoroutine(timer("Rabbi_Meir", 13f));
                break;
            case "Danielle_Richard":
                xFactorsrc.clip = baddies;
                israelFlag.SetActive(true);
                Abie_Safdie.xFactor();
                myMaterials[0].color = Color.yellow;
                myMaterials[1].color = Color.green;
                missPiggy.SetActive(true);
                kermitFrog.SetActive(true);
                StartCoroutine(timer("Danielle_Richard", 9f));
                break;
            case "Israeli_Sasha":
                xFactorsrc.clip = smallTelAviv;
                Abie_Safdie.xFactor();
                beach();
                StartCoroutine(timer("Israeli_Sasha", 8f));
                break;
            case "Ollie_Goldstein":
                xFactorsrc.clip = somewhereRainbow;
                Ollie_Goldstein.xFactor();
                rainbowObject.SetActive(true);
                StartCoroutine(timer("Sasha_Kaplow", 6f));
                break;
            case "Analise_Levy":
                xFactorsrc.clip = shortRocky;
                oxygenBar.SetHealth(oxygenBar.getMaxValue());
                Abie_Safdie.xFactor();
                spawnMountain();
                StartCoroutine(timer("Israeli_Sasha", 8f));
                break;
            case "Adeline_Ellison":
                xFactorsrc.clip = mammaMia;
                Abie_Safdie.xFactor();
                toxicMan = true;
                beach();
                greece.SetActive(true);
                StartCoroutine(timer("Adeline_Ellison", 8f));
                break;
            case "Ido_Katz":
                xFactorsrc.clip = slay;
                onSign.SetActive(true);
                sword.SetActive(true);
                AstronautPlayer.slaySword = true;
                StartCoroutine(timer("Ido_Katz", 13f));
                break;
            case "Nathan_Maryanov":
                xFactorsrc.clip = smoke;
                smokeParticle.SetActive(true);
                oxygenBar.SetHealth(oxygenBar.getMaxValue());
                StartCoroutine(timer("Nathan_Maryanov", 8f));
                break;
            case "Tomer":
                xFactorsrc.clip = bornUSA;
                healthBar.SetHealth(healthBar.getMaxValue());
                heatBar.SetHealth(heatBar.getMaxValue());
                oxygenBar.SetHealth(oxygenBar.getMaxValue());
                israelFlag2.SetActive(true);
                usaFlag.SetActive(true);
                gun1.SetActive(true);
                gun2.SetActive(true);
                StartCoroutine(timer("Tomer", 8f));
                break;
            case "Emma_Healy":
                xFactorsrc.clip = ucla;
                AstronautPlayer.slaySword = true;
                bear1.SetActive(true);
                bear2.SetActive(true);
                bear3.SetActive(true);
                bear4.SetActive(true);
                bear5.SetActive(true);
                astrBody.SetActive(false);
                onSign.SetActive(true);
                StartCoroutine(timer("Emma_Healy", 13f));
                break;
            case "Portia_Carney":
                rack.SetActive(true);
                xFactorsrc.clip = niceRack;
                healthBar.SetHealth(healthBar.getMaxValue());
                StartCoroutine(timer("Portia_Carney", 5f));
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
        sword.SetActive(false);
        GroundTile.berel = false;
        AstronautPlayer.speed = 25f;
        fixBars = false;
        setValues();
        score = 0;

    }

    public IEnumerator timer(string p, float dur){

        float elapsed = 0.0f;

          while (elapsed < dur){

            elapsed += Time.deltaTime;

            if (elapsed > dur - 2f)
                onSign.SetActive(false);
            
            yield return null;
          }
          
        switch(p){
            case "Abie_Safdie":
                    njb.SetActive(false);
                    GameObject[] objs5 = GameObject.FindGameObjectsWithTag("beach");
                    int g = objs5.Length;
                    for (int i = 0; i < g; i++)
                        Destroy(objs5[i]);
                    fixBars = false;
                    break;
            case "Daniel_Moss":
                    AstronautPlayer.danielAlcohol = false;
                    fixBars = false;
                    break;
            case "Hannah_Abikzer":
                    fran.SetActive(false);
                    person.size = personBaseSize;
                    AstronautPlayer.fran = false;
                    fixBars = false;
                    break;
            case "Jonah_Kaplan":
                    judith.SetActive(false);
                    person.size = personBaseSize;
                    AstronautPlayer.fran = false;
                    fixBars = false;
                    break;
            case "Jacque_Velasco":
                    AstronautPlayer.jacquePickup = false;
                    fixBars = false;
                    break;
            case "Jordan_Zicklin":
                    AstronautPlayer.dadBod = false;
                    astr.transform.localScale = baseSize;
                    fixBars = false;
                    break;
            case "Lucinda_Smith":
                    astrBody.SetActive(true);
                    AstronautPlayer.ghoster = false;
                    fixBars = false;
                    break;
            case "Sasha_Kaplow":
                    rainbowObject.SetActive(false);
                    fixBars = false;
                    break;
            case "Lilah_Silberman":
                    israelFlag.SetActive(false);
                    GameObject[] objs = GameObject.FindGameObjectsWithTag("beach");
                    int c = objs.Length;
                    for (int i = 0; i < c; i++)
                        Destroy(objs[i]);
                    fixBars = false;
                    break;
            case "Rabbi_Meir":
                    astr.transform.localScale = baseSize;
                    fixBars = false;
                    break;
            case "Lucie_Nortman":
                    cuteCat.SetActive(false);
                    cutestCat.SetActive(false);
                    cat.SetActive(false);
                    cat4.SetActive(false);
                    cat5.SetActive(false);
                    fixBars = false;
                    break;
            case "Portia_Carney":
                    rack.SetActive(false);
                    fixBars = false;
                    break;
            case "Maddie_Studer":
                    leftSki.transform.localScale = skiSize;
                    rightSki.transform.localScale = skiSize;
                    fixBars = false;
                    break;
            case "Danielle_Richard":
                    israelFlag.SetActive(false);
                    myMaterials[0].color = baseColor0;
                    myMaterials[1].color = baseColor1;
                    missPiggy.SetActive(false);
                    kermitFrog.SetActive(false);
                    fixBars = false;
                    break;
            case "Israeli_Sasha":
                    GameObject[] objs2 = GameObject.FindGameObjectsWithTag("beach");
                    int q = objs2.Length;
                    for (int i = 0; i < q; i++)
                        Destroy(objs2[i]);
                    fixBars = false;
                    break;
            case "Ido_Katz":
                    sword.SetActive(false);
                    AstronautPlayer.slaySword = false;
                    fixBars = false;
                    break;
            case "Tomer":
                    gun1.SetActive(false);
                    gun2.SetActive(false);
                    israelFlag2.SetActive(false);
                    usaFlag.SetActive(false);
                    fixBars = false;
                    break;
            case "Nathan_Maryanov":
                    smokeParticle.SetActive(false);
                    fixBars = false;
                    break;
            case "Emma_Healy":
                    bear1.SetActive(false);
                    bear2.SetActive(false);
                    bear3.SetActive(false);
                    bear4.SetActive(false);
                    bear5.SetActive(false);
                    AstronautPlayer.slaySword = false;
                    astrBody.SetActive(true);
                    fixBars = false;
                    break;
            case "Adeline_Ellison":
                    greece.SetActive(false);
                    toxicMan = false;
                    GameObject[] objs3 = GameObject.FindGameObjectsWithTag("beach");
                        int h = objs3.Length;
                    for (int i = 0; i < h; i++)
                        Destroy(objs3[i]);
                    fixBars = false;
                    break;
            case "Julia_Frank":
                    bat.SetActive(false);
                    soccer1.SetActive(false);
                    soccer2.SetActive(false);
                    fixBars = false;
                    break;
            default:
                fixBars = false;
                break;

        }

    }

    public void beach(){
        r.eulerAngles = new Vector3(270f, 0f, 0f);
        q.eulerAngles = new Vector3(270f, 0f, 180f);
        m.eulerAngles = new Vector3(0f, 180f, 0f);
        float y = astr.transform.position.y;
        float z = astr.transform.position.z;
        float scale = 40f;
        for (int i = 0; i < 5; i++){
            z += scale;
            if (toxicMan){
                Instantiate(man1, new Vector3(14f, y, z), m);
                Instantiate(man1, new Vector3(-14f, y, z), m);
            }
            Instantiate(palmTree, new Vector3(20f, y, z), r);
            Instantiate(palmTree, new Vector3(-20f, y, z), r);
            Instantiate(beachBoard, new Vector3(19f, y, z), r);
            Instantiate(beachBucket, new Vector3(16f, y, z), r);
            Instantiate(beachBoard, new Vector3(-19f, y, z), r);
            Instantiate(beachBucket, new Vector3(-16f, y, z), r);
            Instantiate(beachUmbrella, new Vector3(-17f, y, z), r);
            Instantiate(beachUmbrella, new Vector3(17f, y, z), r);
            Instantiate(beachChair, new Vector3(18f, y, z), r);
            Instantiate(beachChair, new Vector3(-18f, y, z), r);
            Instantiate(beachChair, new Vector3(18f, y, z + 3f), q);
            Instantiate(beachChair, new Vector3(-18f, y, z + 3f), q);
        }

    }

    


    public void spawnMountain(){
        r.eulerAngles = new Vector3(0f, 0f, 0f);
        float y = -3f;
        float z = astr.transform.position.z;
        float scale = 40f;
        for (int i = 0; i < 5; i++){
            z += scale;
            Instantiate(mountain, new Vector3(20f, y, z), r);
            Instantiate(mountain, new Vector3(-20f, y, z), r);

        }

    }

    public void girls(){
        r.eulerAngles = new Vector3(0f, 90f, 0f);
        q.eulerAngles = new Vector3(0f, 270f, 0f);
        m.eulerAngles = new Vector3(270f, 0f, 90f);
        float y = 0f;
        float z = astr.transform.position.z;
        float scale = 20f;
        for (int i = 0; i < 10; i++){
            z += scale;
            Instantiate(girl, new Vector3(-19f, y, z), r);
            Instantiate(girl, new Vector3(19f, y, z), q);
            Instantiate(redHeart, new Vector3(-19f, y + 6, z), m);
            Instantiate(redHeart, new Vector3(19f, y + 6, z), m);
        }

    }

    public void flowers(){
        r.eulerAngles = new Vector3(0f, 0f, 0f);
        float y = 0f;
        float z = astr.transform.position.z;
        float scale = 10f;
        for (int i = 0; i < 20; i++){
            z += scale;
            Instantiate(flower1, new Vector3(randNum(-19f, 19f), y, z + randNum(1f, 10f)), r);
            Instantiate(flower2, new Vector3(randNum(-19f, 19f), y, z + randNum(1f, 8f)), r);
            Instantiate(flower3, new Vector3(randNum(-19f, 19f), y, z + randNum(1f, 8f)), r);
            Instantiate(flower4, new Vector3(randNum(-19f, 19f), y, z + randNum(1f, 8f)), r);
            Instantiate(flower1, new Vector3(randNum(-19f, 19f), y, z + randNum(1f, 8f)), r);
            Instantiate(flower2, new Vector3(randNum(-19f, 19f), y, z + randNum(1f, 8f)), r);
            Instantiate(flower3, new Vector3(randNum(-19f, 19f), y, z + randNum(1f, 8f)), r);
            Instantiate(flower4, new Vector3(randNum(-19f, 19f), y, z + randNum(1f, 8f)), r);

        }

    }

    public float randNum(float x, float y){
        return Random.Range(x, y);
    }

    void Update(){
        if (Input.GetKeyDown("space"))
        {
            int max = xFactorBar.getMaxValue();
            int cur = xFactorBar.GetCurrentHealth();
            if (cur == max){
                getXFactor();
                xFactorsrc.Play();
                xFactorBar.SetHealth(0);
            } 
        }
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
    
        counter += Time.deltaTime;

        float currentOxygen = oxygenBar.GetCurrentHealth();
        float currentHeat = heatBar.GetCurrentHealth();

        if (!fixBars && counter >= 0.5f){
            counter = 0f;
            currentOxygen -= 7;
            currentHeat -= 7;
            }

        oxygenBar.SetHealth(currentOxygen);
        heatBar.SetHealth(currentHeat);

        if (oxygenBar.GetCurrentHealth() == 0){
				SceneManager.LoadScene("OxygenDeath");
			}            

        if (heatBar.GetCurrentHealth() == 0){
				SceneManager.LoadScene("ColdDeath");
			}

        score += (Time.deltaTime * 140);

        if (score >= scoreLevel){
            AstronautPlayer.speed += 2;
            scoreLevel += 5000f;
        }

        scoreText.text = "SCORE: " + score.ToString("0");

        /*
        if (Input.GetKeyDown("space"))
        {
            int max = xFactorBar.getMaxValue();
            int cur = xFactorBar.GetCurrentHealth();
            if (cur == max){
                getXFactor();
                xFactorsrc.Play();
                xFactorBar.SetHealth(0);
            } 
        }
        */
        
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