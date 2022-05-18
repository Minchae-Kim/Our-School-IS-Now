using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Fire : MonoBehaviour
{
    [SerializeField] private int hp = 150;
    public int HP
    {
        get { return hp; }
        set { if (hp > 0) hp = value; }
    }
    [SerializeField] private int fireType;
    public int FireType
    {
        get { return fireType; }
        set { fireType = value; }
    }

    private void Update()
    {
        StopFire();
    }

    private void StopFire()
    {
        ParticleSystem ps = gameObject.GetComponent<ParticleSystem>();

        if (hp == 0)
        {
            GameManager.instance.AddScore(100);            
            ps.Stop();
            StartCoroutine(OffFire());
        }
    }

    IEnumerator OffFire()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }
}
