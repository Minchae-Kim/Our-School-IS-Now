using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    [SerializeField] private GameObject pin;
    [SerializeField] private GameObject hose1;
    [SerializeField] private GameObject hose2;
    [SerializeField] private GameObject effect;
    [SerializeField] private GameObject menu;

    private Vector3 initPosition;
    private Quaternion initRotation;

    private bool isPinRemoved = false;

    private Animator animator;
    private ParticleSystem ps;

    [SerializeField] private int fireExtinguisherType;   // 소화기 종류: 0-A급, 1-B급, 2-C급
    public int FireExtinguisherType
    {
        get { return fireExtinguisherType; }
        set { fireExtinguisherType = value; }
    }

   private bool isSelected = false;

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        ps = effect.GetComponent<ParticleSystem>();

        initPosition = gameObject.transform.position;
        initRotation = gameObject.transform.rotation;
    }
    private void Start()
    {
        StartCoroutine(CheckIsSameType());
    }
    IEnumerator CheckIsSameType()
    {
        yield return new WaitForSeconds(3.0f);
        if(!GetComponentInChildren<EffectInteraction>().IsSame)
        {
            GameObject.Find("XR Rig").GetComponent<Player>().ReducePlayerHp(3.0f);
            GetComponentInChildren<EffectInteraction>().IsSame = true;
        }
    }

    public void ShowMenu()
    {
        if (!isSelected)
            menu.SetActive(true);
    }

    public void EnableSelection()
    {
        isSelected = false;
    }

    public void Retransform()
    {
        gameObject.transform.position = initPosition;
        gameObject.transform.rotation = initRotation;
    }

    public void RemovePin()
    {
        if (!isPinRemoved)
        {
            animator.SetBool("pin", true);
            StartCoroutine(ChangeHose());
            isPinRemoved = true;
        }
    }

    public void Fire()
    {
        if (isPinRemoved)
        {
            if (effect.activeInHierarchy == false)
                effect.SetActive(true);
            else
                ps.Play();
        }
    }

    public void ChangeHose1()
    {
        hose1.SetActive(true);
        hose2.SetActive(false);
    }

    public void ChangeHose2()
    {
        if (isPinRemoved)
        {
            hose1.SetActive(false);
            hose2.SetActive(true);
        }
    }

    public void SqueezeLever()
    {
        if (isPinRemoved)
            animator.SetBool("lever", true);
    }

    public void ReleaseLever()
    {
        if (isPinRemoved)
            animator.SetBool("lever", false);
    }

   
    public void StopEffect()
    {
        ps.Stop();
    }

    IEnumerator ChangeHose()
    {
        yield return new WaitForSeconds(2);
        hose1.SetActive(false);
        hose2.SetActive(true);
    }

    
    // menu
    public void OnSelectAtype()
    {
        fireExtinguisherType = 0;
        isSelected = true;
        menu.SetActive(false);
    }

    public void OnSelectBtype()
    {
        fireExtinguisherType = 1;
        isSelected = true;
        menu.SetActive(false);
    }

    public void OnSelectCtype()
    {
        fireExtinguisherType = 2;
        isSelected = true;
        menu.SetActive(false);
    }
}
