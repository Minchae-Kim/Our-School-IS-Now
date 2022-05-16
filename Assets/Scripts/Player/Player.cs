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
        hp -= damage;
        if(hp>0)
        {
            return hp;
        }
        return 0;
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
