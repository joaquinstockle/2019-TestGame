using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyDamage : MonoBehaviour
{
    public float Amount;

    public void OnTriggerStay(Collider other)
    {
        PlayerHealth.Addpoints(Amount);
    }
}
