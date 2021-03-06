using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartingFire : MonoBehaviour
{
    private int fireType;
    public int FireType
    {
        get { return fireType; }
        set { fireType = value; }
    }


    void Start()
    {
        fireType = Random.Range(0, 3);
        Debug.Log(fireType);

        foreach (Transform fire in transform)
            fire.GetComponent<Fire>().FireType = fireType;
    }
}
