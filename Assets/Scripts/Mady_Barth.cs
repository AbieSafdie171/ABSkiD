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

    private static string[] names = {"Abie_Safdie", "Adeline_Ellison", "Analise_Levy", "Alex_Malve", "Sasha_Kaplow", "Bri_Tafoya", "Chloe_Gold", "Daniel_Moss", "Danielle_Richard",
    "Ella_Diamond", "Israeli_Sasha", "Hannah_Abikzer", "Ido_Katz", "Jacque_Velasco", "Jordan_Cooper", "Jordan_Zicklin", "Jonah_Kaplan", "Julia_Frank",
    "Lilah_Silberman", "Kaya_Rubinstein", "Lucie_Nortman", "Lucinda_Smith", "Maddie_Studer", "Ollie_Goldstein", "Portia_Carney", "Rabbi_Berel",
    "Rabbi_Meir", "Romie_Avivi" };

    public static string xFactor(){

        int rand = Random.Range(0, 28);   

        return names[rand];

    }
}
