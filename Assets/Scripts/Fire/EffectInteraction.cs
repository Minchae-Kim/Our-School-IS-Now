using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectInteraction : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "fire")
        {
            GameObject fireExtinguisher = transform.parent.gameObject;
            int fireExtinguisherType = fireExtinguisher.GetComponent<FireExtinguisher>().FireExtinguisherType;
            int fireType = other.GetComponent<Fire>().FireType;

            if (fireExtinguisherType != fireType)   //  잘못된 소화기 적용 경우
            {
                // 플레이어의 체력 깎임
            }

            else    // 올바른 소화기 적용 경우
            {
                other.GetComponent<Fire>().HP -= 1;
            }
        }
    }
}
