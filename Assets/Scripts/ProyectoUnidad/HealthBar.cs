using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
  


    public void SetHealth(int health)
    {
        slider.value = health;

        //gradient. Evalute()
        //Indica que color va a mostrar donde 1 es el valor mas a la derecha
        fill.color = gradient.Evaluate(slider.normalizedValue);
        //normalizaValue regresa nuestro valor entre 0 a 1
        //Por lo general el Slider tiene un valor de 0 a un valor dado por nosotros
        // Por ejemplo 0 a 100
    }

    public void SetMaxHealth()
    {
        slider.value = 100;
        fill.color = gradient.Evaluate(1f);
    }
}
