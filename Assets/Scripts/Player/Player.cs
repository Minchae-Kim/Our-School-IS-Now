using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private float hp = 500;

    public void ReducePlayerHp()
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
