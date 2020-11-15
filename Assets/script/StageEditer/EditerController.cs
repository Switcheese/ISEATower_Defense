using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum EmenyType
{
    defalut = -1,
    E001=1,E002,E003,E004,
    End
}

public class EditerController : MonoSingleton<EditerController>
{
    [SerializeField]
    GameObject m_popUp;
    [SerializeField]
    Text m_text;

    public int StageNum;
    public int TotalHP;
    [Space(50)]
    public EmenyType m_EmenyType;
    public int SpawnTime;
    public int SpawnCharacterHP;
    public int Position;

    private StageData m_StageData;
    public StageData StageData
    {
        get => m_StageData;
        set => m_StageData = value;
    }
    Dictionary<int, List<int[]>> Dic_StageInfo;

    List<int[]> StageInfo;
    int[] EnemyInfo;
    private void Awake()
    {
        InstanceSetting();
        EnemyInfo = new int[4];
        StageInfo = new List<int[]>();
        m_StageData = new StageData();
        Dic_StageInfo = new Dictionary<int, List<int[]>>();
    }

    public void Set_EnemyInfo()
    {
        StageInfo.Add(EnemyInfo);
        ResetValue();
        m_popUp.SetActive(false);
    }

    public void PopUp_Info()
    {
        m_popUp.SetActive(true);
        EnemyInfo[0] = (int)m_EmenyType;
        EnemyInfo[1] = SpawnTime;
        EnemyInfo[2] = SpawnCharacterHP;
        EnemyInfo[3] = Position;
        m_text.text = string.Format("적 타입 : {0}\n소환 시간 : {1}\n체력 : {2}\n위치 : {3}", EnemyInfo[0], EnemyInfo[1],EnemyInfo[2],EnemyInfo[3]);
    }

    public void PopUpExit()
    {
        m_popUp.SetActive(false);
    }

    public void CompleteStageInfo()
    {
        Dic_StageInfo.Add(StageNum, StageInfo);
        m_StageData.m_StageDictionary.Add(Dic_StageInfo);
        StageManager.BinarySerialize<StageData>(m_StageData, "/Data/StageData.txt");
        StageNum = -1;
        TotalHP = 0;
    }

    void ResetValue()
    {
        m_EmenyType = EmenyType.defalut;
        SpawnTime = 0;
        TotalHP -= SpawnCharacterHP;
        if (TotalHP < 0)
        {
            Debug.LogError("전체 체력이 설정한 값보다 많습니다.");
        }
        SpawnCharacterHP = 0;
        Position = -1;

    }
}
