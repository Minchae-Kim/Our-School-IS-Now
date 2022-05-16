using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    private static UIManager s_instance;

    [SerializeField] private TMP_Text fireCountText;
    private int nowFireCount = 5;

    [SerializeField] private GameObject hitUI;

    private void Awake() => s_instance = this;

    public void ReduceFireCount()
    {
        if (nowFireCount > 0)
            nowFireCount--;
    }

    public void RenewalFireText()
    {
        fireCountText.text = $"남은 화재 장소: {nowFireCount}";
    }

    public void OnHitUI()
    {
        hitUI.SetActive(true);
    }

    public void OffHitUI()
    {
        hitUI.SetActive(false);
    }

}
