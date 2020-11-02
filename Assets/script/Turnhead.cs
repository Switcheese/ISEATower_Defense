using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnhead : MonoBehaviour
{
    public Vector3 touchposition;
    public ScreenTouchControll m_ScreenTouchControll;

    private void Update()
    {
        touchposition = m_ScreenTouchControll.position;
        touchposition.z = this.transform.position.z;
    }

    private void FixedUpdate()
    {
        this.transform.right = (touchposition - this.transform.position);
    }

}
