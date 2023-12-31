using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatBar : MonoBehaviour
{


    public Slider slider;
    public Gradient gradient;
    public Image fill;


    public void SetHealth(float health){

        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);

    }

    public void SetMaxHealth(float health){

        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
        

    }

    public float GetCurrentHealth(){
            return (float)slider.value;
    }

    public float getMaxValue(){
        return (float)slider.maxValue;
    }



}
