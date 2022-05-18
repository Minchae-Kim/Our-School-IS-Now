using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ClearSceneManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private void Start()
    {
        scoreText.text = $"My Score: {GameManager.instance.score}";
    }

    public void GameRestart()
    {
        Time.timeScale = 1f;
        GameManager.instance.time = GameManager.instance.re_time;
        SceneManager.LoadScene("SchoolSceneDayMobile_test");
    }

    public void GameQuit()
    {
        Application.Quit();
    }
}
