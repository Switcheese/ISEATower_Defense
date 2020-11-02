using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScreenTouchControll : MonoBehaviour,IPointerDownHandler,IDragHandler
{
    private RectTransform rectTransform;

    //public GameObject PointerObj;
    public Vector3 position;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {

        position = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Desktop
        

        position.z = -1;

        //PointerObj.transform.position = position;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        position = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Desktop
        //position = eventData.position;

        position.z = -1;

       // PointerObj.transform.position = position;
    }
}
