using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public HealthBar healthBar;

    public FloatBar oxygenBar;

    public FloatBar heatBar;

    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        // currentHealth = 5;
        healthBar.SetMaxHealth(5);
        oxygenBar.SetMaxHealth(1000);
        heatBar.SetMaxHealth(1000);
    }

    // Update is called once per frame
    void Update()
    {
        
        float currentOxygen = oxygenBar.GetCurrentHealth();

        currentOxygen -= (57 * Time.deltaTime);

        oxygenBar.SetHealth(currentOxygen);

        if (oxygenBar.GetCurrentHealth() == 0){
				SceneManager.LoadScene("HowtoPlay");
			}

        float currentHeat = heatBar.GetCurrentHealth();

        currentHeat -= (57 * Time.deltaTime);

        heatBar.SetHealth(currentHeat);

        if (heatBar.GetCurrentHealth() == 0){
				SceneManager.LoadScene("HowtoPlay");
				}


    }
}
