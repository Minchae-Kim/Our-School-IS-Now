using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class FireDamage : MonoBehaviour
{
    public UnityEvent fireDamage;
    [SerializeField] private GameObject hitUI;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            hitUI.SetActive(true);
            fireDamage.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            hitUI.SetActive(false);
        }
    }
}
