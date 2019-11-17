﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;
    public float maxValue = 20f;

    void Awake()
    {
        value = maxValue;
    }

    public void UpdateValue(float amount)
    {
        value += amount * Time.deltaTime;
    }

    public void ChangeValue(float amount)
    {
        value = amount;
    }
      
    public void UpdateValueLimitZero(float amount)
    {
        if(value < 0)
        {
            value = 0;
        }
        else
        {
            UpdateValue(amount);
        }
    }
    public void UpdateValueLimitZeroAndMaxValue(float amount) 
    {
                 
        if (value < maxValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = maxValue;
        }
        UpdateValueLimitZero(amount);
    }
    
}