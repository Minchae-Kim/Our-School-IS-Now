using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FireParent : MonoBehaviour
{
    public UnityEvent onFireOff;
    private List<GameObject> fires = new List<GameObject>();

    private void Awake()
    {
        foreach (Transform fire in transform)
            fires.Add(fire.gameObject);
    }

    private void Update()
    {
        if(!isFireOff())
        {
            if (onFireOff == null)
                Debug.Log("불꺼짐 이벤트에 아무것도 없습니다.");
            else
            {
                onFireOff.Invoke();
                this.gameObject.SetActive(false);
            }
        }
    }

    private bool isFireOff()
    {
        foreach (var fire in fires)
            if (fire.activeSelf)
                return true;

        return false;
    }



}
