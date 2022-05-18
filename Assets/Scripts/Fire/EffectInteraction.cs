using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectInteraction : MonoBehaviour
{
    private bool isSame = true;
    public bool IsSame 
    {
        get => isSame;
        set => isSame = value;
    }

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
                isSame = false;
                if(GameManager.instance.istimeCheck)
                {
                    UIManager.s_instance.OnHitUI();
                    GameObject.Find("XR Rig").GetComponent<Player>().ReducePlayerHp(1.0f);
                }
            }

            else    // 올바른 소화기 적용 경우
            {
                other.GetComponent<Fire>().HP -= 1;
                isSame = true;
            }
        }
    }
}
