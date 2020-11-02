using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    [SerializeField]
    GameObject ReadyUI;
    public void Exit()
    {
        ReadyUI.SetActive(false);
    }
}
