using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    
    [SerializeField] private float hp = 300;
    public float HP => hp;

    public void ReducePlayerHp(float amount)
    {
        if (hp >= 0.5f)
            hp -= 0.5f;
        Debug.Log($"player hp : {hp}");

        if (hp <= 0)
        {
            hp = 0;
            GameManager.instance.GameOver();
        }
    }

}
