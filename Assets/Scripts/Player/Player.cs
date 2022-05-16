using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public int hp = 100;
    public bool isGrabTowel = false;

    public void ReducePlayerHp()
    {
        hp -= 10;
        if(hp>0)
        {
            return;
        }
        hp = 0;
    }
    public bool OnGrabTowel()
    {
        isGrabTowel = true;
        return isGrabTowel;
    }
    public bool OffGrabTowel()
    {
        isGrabTowel = false;
        return isGrabTowel;
    }
}
