using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class FireParent : MonoBehaviour
{
    public UnityEvent offFire = null;

    GameObject[] fires = new GameObject[2];

    private void Awake()
    {
        fires[0] = transform.GetChild(0).gameObject;
        fires[1] = transform.GetChild(1).gameObject;
    }

    private bool isFire()
    {
        if(!fires[0].activeSelf&&!fires[1].activeSelf)
        {
            Debug.Log("fire is extinguish");
            return false;
        }
        return true;
    }


}
