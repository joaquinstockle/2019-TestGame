using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public EnemyDamage damage;
    
    public static float health;

    public Image healthBar;

    public bool Dead = false;

    



    private void Start()
    {
        health = 1f;
    }
    
    public static void Addpoints (float Amount) 
    {
        health += Amount * Time.deltaTime;
    }

    
    void Update()
    {
        healthBar.fillAmount = health;

        
        if (health < 0)
            health = 0;
        if (health > 1)
            health = 1;

        if (health <= 0)
            Dead = true;
        if (health > 0)
            Dead = false;

        if (Dead)
        {

        }
    }
}
