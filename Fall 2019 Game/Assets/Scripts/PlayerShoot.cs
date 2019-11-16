using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerShoot : MonoBehaviour
{
    public float pew = 5f;
    public float range = 20f;
    public Camera cam;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
             Shoot();
        }
           
    }
    void Shoot ()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target != null)
            {
                target.EnemyHit(pew);
            }
        }
    }

}
    

    
