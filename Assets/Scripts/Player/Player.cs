using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public UnityEvent onPlayerEvent;

    public int hp = 100;
    public bool isGrabTowel = false;

    public int ReducePlayerHp(int damage)
    {
        if(hp>0)
        {
            hp -= damage;
        }
        return hp;
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
