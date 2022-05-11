﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager s_instance;

    //화살표
    [SerializeField] private GameObject explainArrow;

    //시작 ui, 물수건 제작 UI, 화재 종류 설명 ui
    //[SerializeField] private GameObject startUI;
    //[SerializeField] private GameObject towelUI;
    //[SerializeField] private GameObject fireTypeUI;



    private void Awake() => s_instance = this;
    private void Start()
    {
        
    }

    public void Show(GameObject UI)
    {
        UI.SetActive(true);
    }

    public void Hide(GameObject UI)
    {
        UI.SetActive(false);
    }



}
