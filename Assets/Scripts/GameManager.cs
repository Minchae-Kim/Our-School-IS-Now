using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject startFire1;
    [SerializeField] private GameObject startFire2;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }

    void Start()
    {
        StartRandomFire();
    }

    private void StartRandomFire()
    {
        int type = Random.Range(0, 3);
        startFire1.GetComponent<Fire>().FireType = type;
        startFire2.GetComponent<Fire>().FireType = type;
    }

    
}
