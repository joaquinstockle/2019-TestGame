using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class DS : MonoBehaviour
{
    private GameObject[] enemies = { };
    private int numOfEnemies = 0;
    public float maxEnemies = 1f;
    public GameObject enemy;
    
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag ("Enemy");
        numOfEnemies = enemies.Length;
    }
    void Update()
    {
        maxEnemies += 0.01f;
        
        enemies = GameObject.FindGameObjectsWithTag ("Enemy");
        numOfEnemies = enemies.Length;

        if (numOfEnemies < maxEnemies && Time.timeScale > .5f)
        {
            Instantiate(enemy, new Vector3(UnityEngine.Random.value, 0, UnityEngine.Random.value),
                Quaternion.identity);
        }
        
        Debug.Log("numEnemies:" + numOfEnemies);
    }
}
