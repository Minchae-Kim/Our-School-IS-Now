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
            Debug.Log("Collision!");
            return;
        }
        if (other.tag == "smoke" && wetTowel.GetComponent<WetTowel>().IsGrabbed)
        {
            hitUI.SetActive(false);
            Debug.Log("Towel Grabbed & Collision!");
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
