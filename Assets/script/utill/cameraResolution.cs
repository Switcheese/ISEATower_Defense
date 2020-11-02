using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class cameraResolution : MonoBehaviour
{
    public float Horizon, Vertical;
    public float m_scaleheight, m_scalewidth;
    private void Awake()
    {
        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;

        m_scaleheight = ((float)Screen.width / Screen.height) / ((float)Horizon / Vertical); //(가로) / (세로)
        m_scalewidth = 1f / m_scaleheight;

        if (m_scaleheight < 1)
        {
            rect.height = m_scaleheight;
            rect.y = (1f - m_scaleheight) / 2f;
        }
        else
        {
            rect.width = m_scalewidth;
            rect.x = (1f - m_scalewidth) / 2f;
        }
        camera.rect = rect;
        Screen.SetResolution(1920, 1080, true);
    }
}

