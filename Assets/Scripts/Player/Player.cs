﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float hp = 300;


    public void ReducePlayerHp()
    {
        hp -= 0.5f;
        Debug.Log($"player hp : {hp}");
        if(hp>0)
        {
            return;
        }
        hp = 0;
    }

}
