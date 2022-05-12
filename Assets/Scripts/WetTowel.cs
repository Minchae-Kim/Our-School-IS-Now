using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class WetTowel : MonoBehaviour
{
    public UnityEvent doorOpenCheck;
    [SerializeField] private GameObject arrow;
    private bool isGrabbed = false;
    public bool IsGrabbed => isGrabbed;

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void OnArrow()
    {
        arrow.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1f, gameObject.transform.position.z);
        arrow.transform.rotation = Quaternion.Euler(new Vector3(-90f, 0f, 0f));
        arrow.SetActive(true);
    }

    public void OffArrow()
    {
        arrow.SetActive(false);
    }

    public void Grab()
    {
        isGrabbed = !isGrabbed;
    }

}
