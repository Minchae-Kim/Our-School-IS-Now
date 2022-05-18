using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathSceneManager : MonoBehaviour
{
    public void GameRestart()
    {
        SceneManager.LoadScene("SchoolSceneDayMobile_test");
    }

    public void GameQuit()
    {
        Application.Quit();
    }
}
