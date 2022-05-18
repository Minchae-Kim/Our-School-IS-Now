using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public float time = 600.0f;

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

    private void Start()
    {
        score = 0;
        time = 600.0f;
    }

    private void Update()
    {
        
    }

    public void AddScore(int amount)
    {
        score += amount;
        UIManager.s_instance.UpdateScore();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    public void GameClear()
    {
        SceneManager.LoadScene("GameClearScene");
    }
}
