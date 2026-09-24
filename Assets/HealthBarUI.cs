using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    public float Health, Maxhealth, Width, Height;

    [SerializeField] 
    private RectTransform healthBar;

    //Estableix la vida maxima per especificar la mida de la barra.
    public void SetMaxHealth(float maxHealth)
    {
        Maxhealth = maxHealth; 
    }

    //Modifica la barra depenent de la vida actual.
    public void SetHealth(float health)
    {
        Health = health;
        float newWidth = (Health / Maxhealth) * Width;

        healthBar.sizeDelta = new Vector2(newWidth, Height);
    }
}
