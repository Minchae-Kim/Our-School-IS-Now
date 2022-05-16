using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class FireDamage : MonoBehaviour
{
    public UnityEvent fireDamage;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Collision");
            fireDamage.Invoke();
        }
    }
}
