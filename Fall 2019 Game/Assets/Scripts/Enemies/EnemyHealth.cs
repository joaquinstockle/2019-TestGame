using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 20f;

    public void EnemyHit(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Death();
        }
    }

    public void Death()
    {
        Destroy(gameObject);
    }
}
