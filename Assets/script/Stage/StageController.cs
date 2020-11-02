using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    public GameObject ReadyUI;
    public void OpenReadyUI()
    {
        ReadyUI.SetActive(true);
    }
}
