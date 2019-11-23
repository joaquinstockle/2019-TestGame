﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerCha : MonoBehaviour
{

    public GameObject ScreenDeath;


    public void Start()
    {
        ScreenDeath.SetActive(false);

    }
    
    public void Respawn()
    {
        StartCoroutine("DeathScreenCo");
    }

    public void DeathScreenCo()
    {
        ScreenDeath.SetActive(true);
        Cursor.lockState = CursorLockMode.None;


    }
}
