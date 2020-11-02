using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image m_FileValue;
    // Start is called before the first frame update
    void Start()
    {
        m_FileValue.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProgressValueControll()
    {
        m_FileValue.fillAmount = 1;
    }
}
