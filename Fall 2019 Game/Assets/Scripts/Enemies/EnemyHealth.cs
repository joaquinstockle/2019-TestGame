using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class EnemyHealth : MonoBehaviour
{
    public float health = 20f;

    public int PointToAdd;

    public Camera cam;

    public Vector3 push;

    public Rigidbody Enemy;

    public void EnemyHit(float amount)
    {
        health -= amount;
        
        push = transform.position - cam.transform.position;
        Enemy.AddForce(push * .5f,ForceMode.VelocityChange);
        if (health <= 0f)
        {
            Death();
        }
    }

    public void EnemyStruck(float amount)
    {
        //health -= amount;
        
        push = transform.position - cam.transform.position;
        Enemy.AddForce(push * 5,ForceMode.VelocityChange);


        if (health <= 0f)
        {
            Death();
        }
    }

    public void knockBack()
    {
        
    }

    public void Death()
    {
        Destroy(gameObject);
        Points.Addpoints (PointToAdd);
    }
}
