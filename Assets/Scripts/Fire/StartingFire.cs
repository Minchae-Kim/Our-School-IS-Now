using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        foreach (Transform fire in transform)
            fire.GetComponent<Fire>().FireType = fireType;
    }
}
