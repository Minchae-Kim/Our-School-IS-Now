using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public int hp = 100;


    public void ReducePlayerHp()
    {
        hp -= 10;
        Debug.Log($"player hp : {hp}");
        if(hp>0)
        {
            return;
        }
        hp = 0;
    }

}
