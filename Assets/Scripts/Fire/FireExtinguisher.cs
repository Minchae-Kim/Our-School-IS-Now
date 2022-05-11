﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    [SerializeField] private GameObject pin;
    [SerializeField] private GameObject hose1;
    [SerializeField] private GameObject hose2;
    [SerializeField] private GameObject effect;
    [SerializeField] private GameObject menu;

    private bool isPinRemoved = false;

    private Animator animator;
    private ParticleSystem ps;

    private int type;   // 소화기 종류: 0-A급, 1-B급, 2-C급
    public int Type => type;

   private bool isSelected = false;

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        ps = effect.GetComponent<ParticleSystem>();
    }

    public void ShowMenu()
    {
        if (!isSelected)
            menu.SetActive(true);
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
        type = 0;
        isSelected = true;
        menu.SetActive(false);
    }

    public void OnSelectBtype()
    {
        type = 1;
        isSelected = true;
        menu.SetActive(false);
    }

    public void OnSelectCtype()
    {
        type = 2;
        isSelected = true;
        menu.SetActive(false);
    }
}