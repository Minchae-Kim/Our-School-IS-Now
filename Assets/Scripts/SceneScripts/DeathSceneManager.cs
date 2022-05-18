using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathSceneManager : MonoBehaviour
{
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
