using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{
    private static StartSceneManager instance = null;
    public static StartSceneManager Instance
    {
        get
        {
            return instance;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if(instance)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    
    public void OnGameStart()
    {
        SceneManager.LoadScene("SchoolSceneDayMobile_test");
    }


    public void OnGameQuitButton()
    {
        Application.Quit();
    }

}
