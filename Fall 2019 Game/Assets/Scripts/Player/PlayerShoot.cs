using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Events;
using Vector3 = UnityEngine.Vector3;

public class PlayerShoot : MonoBehaviour
{
    public float pew = 5f;
    public float pow = 10f;
    public float range = 20f;
    public float mRange = 1f;
    public Camera cam;
    public Vector3 Char;
    public Vector3 push;
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.timeScale > .5f)
        {
             Shoot();
        }

       if (Input.GetButtonDown("Fire2") && Time.timeScale > .5f)
        {
            Punch();
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

    void Punch()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, mRange))
        {
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target != null)
            {
                target.EnemyStruck(pow);
                
               
            }
        }
    }

}
    

    
