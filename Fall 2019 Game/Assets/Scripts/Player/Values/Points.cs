using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;


public class Points : MonoBehaviour
{
    
    public static float Score;
    
    public float AddedPoint = .5f;
    
    Text ScoreText;


    void Start()
    {
        ScoreText = GetComponent<Text>();

        Score = 0;
        
    }

    void Update()
    {
        ScoreText.text = " " + Mathf.RoundToInt(Score);
        Score += AddedPoint * Time.deltaTime;


    }
    public static void Addpoints (int PointToAdd) {
        Score += PointToAdd;
    }


}
