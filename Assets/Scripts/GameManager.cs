using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public float time = 0.0f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
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
        SceneManager.LoadScene("GameClearScene");
    }

    public void GameClear()
    {

    }
}
