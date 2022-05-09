using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager s_instance;

    [SerializeField] private UI startingUI;
    [SerializeField] private UI[] UIs;
    private UI currentUI;
    private readonly Stack<UI> history = new Stack<UI>();

    private void Awake() => s_instance = this;

    public static T GetUI<T>() where T : UI
    {
        for (int i=0; i<s_instance.UIs.Length; i++)
        {
            if (s_instance.UIs[i] is T tUI)
                return tUI;
        }
        return null;
    }

    public static void Show<T>(bool remember = true) where T : UI
    {
        for (int i=0; i<s_instance.UIs.Length; i++)
        {
            if (s_instance.UIs[i] is T)
            {
                if (s_instance.currentUI != null)
                {
                    if (remember)
                        s_instance.history.Push(s_instance.currentUI);

                    s_instance.currentUI.Hide();
                }

                s_instance.UIs[i].Show();
                s_instance.currentUI = s_instance.UIs[i];
            }
        }
    }

    public static void Show(UI ui, bool remember = true)
    {
        if (s_instance.currentUI != null)
        {
            if (remember)
                s_instance.history.Push(s_instance.currentUI);

            s_instance.currentUI.Hide();
        }

        ui.Show();
        s_instance.currentUI = ui;
    }

    public static void ShowLast()
    {
        if (s_instance.history.Count != 0)
        {
            Show(s_instance.history.Pop(), false);
        }
    }
}
