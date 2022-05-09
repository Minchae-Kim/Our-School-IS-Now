using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectInteraction : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "fire")
        {
            other.GetComponent<Fire>().HP -= 1;
        }
    }
}
