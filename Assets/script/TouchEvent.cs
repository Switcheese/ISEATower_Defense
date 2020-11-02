using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchEvent : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    public Vector3 touchInfo;
    public Turnhead m_turn;
    public GameObject pointerObj;
    public void OnDrag(PointerEventData eventData)
    {
        touchInfo = eventData.pointerCurrentRaycast.gameObject.transform.localPosition ;
        Debug.Log("Drag pos :" + touchInfo);
        pointerObj.transform.position = touchInfo;
        //m_turn.turn();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        touchInfo = eventData.position;
        Debug.Log("OnPointerDown pos :" + touchInfo);
        pointerObj.transform.position = touchInfo;
        //m_turn.turn();
    }

    //public Quaternion TouchRotation; // 최종회전 값
    //private Ray InputRay; // 레이 변수
    //private RaycastHit Hit; // 정보가 들어갈 변수
    //private LayerMask Layer; // 레이어마스크 변수 
    //private float RayLength = 100; // 레이 길이 변수

    //void ViewControl()
    //{
    //    if (Application.platform == RuntimePlatform.Android) // 현재 플렛폼이 안드로이드라면
    //    {
    //        InputRay = Camera.main.ScreenPointToRay(Input.GetTouch(0).position); // 사용할 레이의 위치 생성(터치)
    //    }
    //    else
    //    {
    //        InputRay = Camera.main.ScreenPointToRay(Input.mousePosition); // 마우스
    //    }
    //    if (Physics.Raycast(InputRay, out Hit, RayLength, Layer)) // 레이생성(Hit= 변수에 결과값 저장, RayLength= 레이 길이, Layer= 레이가 충돌된 오브젝트 레이어 가 해당레이어인경우에만 캐치함)
    //    {
    //        Debug.Log(Layer.value.ToString());
    //        Vector3 playerToMouse = Hit.point - transform.position;
    //        playerToMouse.y = 0f;  // Y방향은 사용하지 않기 때문에 0
    //        TouchRotation = Quaternion.LookRotation(playerToMouse); // LookRotation함수를 이용해 회전
    //    }
    //}
    //private void Update()
    //{
    //    ViewControl();
    //}


}
