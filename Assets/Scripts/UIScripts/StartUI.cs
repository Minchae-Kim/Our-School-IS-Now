using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartUI : UI
{
    [SerializeField] private TextMeshProUGUI TMtext;
    [SerializeField] private GameObject startingFire;

    void Start()
    {
        int type = startingFire.GetComponent<StartingFire>().FireType;

        switch (type)
        {
            case 0:
                TMtext.text = "불씨가 튀어 불이 났습니다.\n불을 끌만한 것을 찾아보세요!";
                break;
            case 1:
                TMtext.text = "알코올램프에서 불이 났습니다.\n불을 끌만한 것을 찾아보세요!";
                break;
            case 2:
                TMtext.text = "콘센트에서 불이 났습니다.\n불을 끌만한 것을 찾아보세요!";
                break;
        }

       
    }
}
