using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{    
    public float Health, MaxHealth;

    [SerializeField]
    private HealthBarUI healthBar;

    void Start()
    {
        healthBar.SetMaxHealth(MaxHealth);
    }

    void update()
    {
        if(Input.GetKeyDown("d"))
        {
            SetHealth(-20f);
        }
        if(Input.GetKeyDown("h"))
        {
            SetHealth(20f);
        }
    }
    public void SetHealth(float healthChange)
    {
        Health += healthChange;
        Health = Mathf.Clamp(Health, 0, MaxHealth);

        healthBar.SetHealth(Health);

    }
    
}
