using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager s_instance;

    [SerializeField] private TMP_Text fireCountText;
    [SerializeField] private TMP_Text scoreText;
    private int nowFireCount = 5;

    [SerializeField] private GameObject hitUI;

    [SerializeField] private TMP_Text timer;

    [SerializeField] private Image hpBar;

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

    public void UpdateScore()
    {
        scoreText.text = $"점수: {GameManager.instance.score}";
    }

    public void UpdateTimer()
    {
        int minute = (int)GameManager.instance.time / 60;
        int seconds = (int)GameManager.instance.time % 60;
        timer.text = minute.ToString() + " : " + seconds.ToString();
    }

    public void UpdateHP(float hp)
    {
        hpBar.fillAmount = hp / 300f;
    }
}
