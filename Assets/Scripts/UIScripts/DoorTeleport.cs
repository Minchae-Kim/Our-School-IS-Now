using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class DoorTeleport : MonoBehaviour
{
    private XRSimpleInteractable interactable;
    [SerializeField] private GameObject teleportPoint;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject wetTowel;

    void Start()
    {
        interactable = GetComponent<XRSimpleInteractable>();
    }

    public void EnableInteraction()
    {
        interactable.enabled = true;
    }

    public void Teleport()
    {
        if (!wetTowel.GetComponent<WetTowel>().IsGrabbed)
            return;
        player.transform.position = teleportPoint.transform.position;
        player.transform.rotation = teleportPoint.transform.rotation;
        interactable.enabled = false;
    }
}
