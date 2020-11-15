using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class positionButtonInfo : MonoBehaviour
{
    Button m_Button;
    public int ButtonText;

    private void Start()
    {
        m_Button = this.transform.GetComponent<Button>();
        m_Button.onClick.AddListener(PositionButtonClick);
    }

    public void PositionButtonClick()
    {
        EditerController.instance.Position = ButtonText;
    }
}
