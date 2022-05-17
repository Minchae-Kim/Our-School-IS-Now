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
            UIManager.s_instance.OnHitUI();
            fireDamage.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            UIManager.s_instance.OffHitUI();
        }
    }
}
