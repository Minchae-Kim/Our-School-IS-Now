using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [HideInInspector] public int score = 0;
    public float time = 600.0f;
    public float re_time = 600.0f;
    [HideInInspector] public bool istimeCheck = false;

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
        StartCoroutine(CheckIsSameType());
    }

    private void FixedUpdate()
    {        
        TimeCountDown();
        UIManager.s_instance.UpdateTimer();        
    }
    void TimeCountDown()
    {        
        time -= Time.deltaTime;
        if(time <= 0.0f)
        {
            GameOver();
        }
    }

    IEnumerator CheckIsSameType()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            istimeCheck = !istimeCheck;
            UIManager.s_instance.OffHitUI();
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        UIManager.s_instance.UpdateScore();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        StopCoroutine(CheckIsSameType());
        SceneManager.LoadScene("GameOverScene");
    }

    public void GameClear()
    {
        Time.timeScale = 0;
        score += 3 * (int)GameObject.Find("XR Rig").GetComponent<Player>().HP;
        SceneManager.LoadScene("GameClearScene");
    }
}
