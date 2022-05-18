using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    [SerializeField] private GameObject wetTowel;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "smoke" && !wetTowel.GetComponent<WetTowel>().IsGrabbed)
        {
            UIManager.s_instance.OnHitUI();
            GetComponent<Player>().ReducePlayerHp(0.5f);
            return;
        }
        if (other.tag == "smoke" && wetTowel.GetComponent<WetTowel>().IsGrabbed)
        {
            UIManager.s_instance.OffHitUI();
            return;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "smoke")
        {
            UIManager.s_instance.OffHitUI();
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "finish")
        {
            GameManager.instance.GameClear();
        }
    }
}
