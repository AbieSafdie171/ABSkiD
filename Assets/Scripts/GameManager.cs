using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public HealthBar healthBar;

    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 5;
        healthBar.SetMaxHealth(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
