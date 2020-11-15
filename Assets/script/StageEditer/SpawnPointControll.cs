using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPointControll : MonoSingleton<SpawnPointControll>
{
    public GameObject[] positionObject;
    public Text[] PositionName;
    public positionButtonInfo[] m_positionButtonInfo;

    private void Awake()
    {
        InstanceSetting();
        //positionObject = new GameObject[168];
        PositionName = new Text[positionObject.Length];
        m_positionButtonInfo= new positionButtonInfo[positionObject.Length];
    }
    private void Start()
    {
        for (int i = 0; i < positionObject.Length; i++)
        {
            m_positionButtonInfo[i] = positionObject[i].GetComponentInChildren<positionButtonInfo>();
            PositionName[i] = positionObject[i].GetComponentInChildren<Text>();

            PositionName[i].text = (i + 1).ToString();
            m_positionButtonInfo[i].ButtonText = (i + 1);
        }
    }

    
}
