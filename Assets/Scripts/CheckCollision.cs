using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    [SerializeField] private GameObject hitUI;
    [SerializeField] private GameObject wetTowel;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "smoke" && !wetTowel.GetComponent<WetTowel>().IsGrabbed)
        {
            hitUI.SetActive(true);
            return;
        }
        if (other.tag == "smoke" && wetTowel.GetComponent<WetTowel>().IsGrabbed)
        {
            hitUI.SetActive(false);
            return;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "smoke")
        {
            hitUI.SetActive(false);
        }
    }
}
