using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager s_instance;

    //남은 화재 갯수 UI
    [SerializeField] private Text FireText;
    //화살표
    //[SerializeField] private GameObject explainArrow;

    //시작 ui, 물수건 제작 UI, 화재 종류 설명 ui
    //[SerializeField] private GameObject startUI;
    //[SerializeField] private GameObject towelUI;
    //[SerializeField] private GameObject fireTypeUI;

    //화재 갯수 UI
    private int fireCount = 5;


    private void Awake() => s_instance = this;
    private void Start()
    {
        FireText.text = $"Reamain Fire  : {fireCount}";
    }

    public void Show(GameObject UI)
    {
        UI.SetActive(true);
    }

    public void Hide(GameObject UI)
    {
        UI.SetActive(false);
    }

    public void FireCountDown()
    {
        if (fireCount != 0)
            fireCount--;
    }

    public void RenewalFireCountDown()
    {
        FireText.text = $"Reamain Fire  : {fireCount}";
    }


}
