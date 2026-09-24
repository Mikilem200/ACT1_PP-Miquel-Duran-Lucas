using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Health, MaxHealth;

    [SerializeField]
    private HealthBarUI healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth(MaxHealth);
    }

    //Establim la vida del jugador
    public void setHealth(float healthChange)
    {
        Health += healthChange;
        Health = Mathf.Clamp(Health, 0, MaxHealth);

        healthBar.SetHealth(Health);
    }
    //Treu vida al clicar
    public void OnClickHurt()
    {
        setHealth(-20f);
    }
    //Dona Vida al Clicar
    public void OnClickHeal()
    {
        setHealth(20f);
    }
    //Posa la vida a zero.
    public void OnClickKILL()
    {
        setHealth(-100f);
    }
    //Si el valor vida es a zero y el boto es clica, es torna 100., si no, no passa res.
    public void OnClickRevive()
    {
        if (Health == 0)
        {
            setHealth(100f);
        }
        else
        {
            Debug.Log("Life remains here!");
        }
        
    }
}