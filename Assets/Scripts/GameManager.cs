using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public float time = 0.0f;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }

    public void AddScore(int amount)
    {
        score += amount;
        UIManager.s_instance.UpdateScore();
    }

    public void GameOver()
    {
        return;
    }

    public void GameClear()
    {

    }
    
    public void Restart()
    {

    }
}
