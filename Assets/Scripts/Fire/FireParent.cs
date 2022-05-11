using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FireParent : MonoBehaviour
{
    public UnityEvent offFire;
    private GameObject[] fires = new GameObject[2];

    private void Awake()
    {
        fires[0] = transform.GetChild(0).gameObject;
        fires[1] = transform.GetChild(1).gameObject;
    }

    private void Update()
    {
        if(!isFire())
        {
            if (offFire == null)
                Debug.Log("불꺼짐 이벤트에 아무것도 없습니다.");
            else
            {
                offFire.Invoke();
                this.gameObject.SetActive(false);
            }
        }
    }

    private bool isFire()
    {
        if (!fires[0].activeSelf && !fires[1].activeSelf)
            return false;
        return true;
    }



}
