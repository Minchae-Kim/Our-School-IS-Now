using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;

public class QuestItem : MonoBehaviour
{
    private XRSimpleInteractable interactable;

    private static int collectedItems = 0;

    public UnityEvent onAllCollected;

    private void Start()
    {
        interactable = GetComponent<XRSimpleInteractable>();
    }

    public void EnableInteraction()
    {
        interactable.enabled = true;
    }

    public void CountItems()
    {
        collectedItems++;
        gameObject.SetActive(false);

        if (collectedItems == 2)
            onAllCollected.Invoke();
    }
}
