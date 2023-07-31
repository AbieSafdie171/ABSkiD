using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mady_Barth : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coolness = 85;

    public static int speed = 15;

    public static int stamina = 60;

    public static int skiingIQ = 90;

    public static int alcTol = 50;

    private static string[] names = {"Abie_Safdie", "Alex_Malve", "Bri_Tafoya", "Chloe_Gold", "Daniel_Moss",
    "Ella_Diamond", "Hannah_Abikzer", "Jacque_Velasco", "Jordan_Cooper", "Jordan_Zicklin", "Jonah_Kaplan", "Julia_Frank",
    "Lilah_Silberman", "Kaya_Rubinstein", "Lucie_Nortman", "Lucinda_Smith", "Maddie_Studer", "Portia_Carney", "Rabbi_Berel",
    "Rabbi_Meir", "Romie_Avivi" };

    public static string xFactor(){

        int rand = Random.Range(0, 21);   

        return names[rand];

    }
}
