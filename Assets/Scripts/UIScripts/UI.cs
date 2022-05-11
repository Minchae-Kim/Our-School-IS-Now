using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public virtual void Hide() => gameObject.SetActive(false);
    public virtual void Show() => gameObject.SetActive(true);
}
