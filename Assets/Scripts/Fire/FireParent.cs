using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FireParent : MonoBehaviour
{
    public UnityEvent onFireOffUI = null;

    GameObject[] fires = new GameObject[2];

    private void Awake()
    {
        fires[0] = transform.GetChild(0).gameObject;
        fires[1] = transform.GetChild(1).gameObject;
    }

    public bool IsFire()
    {
        if (fires[0].activeSelf == false && fires[1].activeSelf == false)
        {
            if (onFireOffUI == null)
                Debug.Log("화재 발생 이벤트 함수가 추가가 안됨");
            else
                onFireOffUI.Invoke();
            return false;
        }
        return true;
    }


}
