using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class FireDamage : MonoBehaviour
{
    public UnityEvent fireDamage;
    IEnumerator Damage()
    {
        if (fireDamage != null)
            fireDamage.Invoke();
        yield return new WaitForSeconds(1.5f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            StartCoroutine(Damage());
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            StopCoroutine(Damage());
    }
}
