using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TouchTitle : MonoBehaviour,IPointerClickHandler
{
    
    public void OnPointerClick(PointerEventData eventData)
    {
        //SceneManager.LoadScene(GameManager.instance.m_gameScene);
        this.gameObject.SetActive(false);
    }

}
