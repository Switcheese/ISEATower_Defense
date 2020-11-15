using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;


[System.Serializable]
public class StageData
{
    //Key
    //Stage

    //Values
    //public int[] Position;
    //public int[] Enemey;
    //public int[] SpawnTime;
    //public int[] HP;
    public List<Dictionary<int, List<int[]>>> m_StageDictionary;
    public StageData()
    {
        m_StageDictionary = new List<Dictionary<int, List<int[]>>>();
    }

}

public class StageManager : MonoSingleton<StageManager>
{
    private List<Dictionary<string, string>> m_StageDictionary;
    public List<Dictionary<string, string>> StageDictionary
    {
        get => m_StageDictionary;
        set => m_StageDictionary = value;
    }
    private StageData m_StageData;
    public StageData StageData
    {
        get => m_StageData;
        set => m_StageData = value;
    }
    private void Awake()
    {
        InstanceSetting();
        m_StageData = new StageData();
        //m_StageData = new StageData[20];
        //m_StageDictionary = new List<Dictionary<string, string>>();
        //m_StageDictionary = csvReader.Read("stageInfo");
        //ConvertStageData();
        if (!Directory.Exists(/*Application.persistentDataPath*/Application.dataPath + "/Data"))
        {
            Directory.CreateDirectory(Application.dataPath + "/Data");
            FileFinder();
        }
        else
        {
            FileFinder();
        }
    }
    void FileFinder()
    {

        if (!File.Exists(Application.dataPath + "/Data/StageData.txt"))
        {
            Debug.Log("Stage 정보가 없습니다.");

            //BinarySerialize<StageData>(StageManager.instance.StageData, "/Data/StageData.txt");
        }
        else
        {
            StageData = StageManager.BinaryDeserialize<StageData>("/Data/StageData.txt");
        }
    }
    /// <summary>
    /// 시리얼라이즈 바이너리
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="t"></param>
    /// <param name="filePath"></param>
    public static void BinarySerialize<T>(T t, string filePath)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(Application.dataPath /*Application.persistentDataPath*/ + filePath, FileMode.Create);
        formatter.Serialize(stream, t);
        stream.Close();
    }

    /// <summary>
    /// 디시리얼라이즈 바이너리
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public static T BinaryDeserialize<T>(string filePath)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(Application.dataPath /*Application.persistentDataPath*/  + filePath, FileMode.Open);
        T t = (T)formatter.Deserialize(stream);
        stream.Close();

        return t;
    }
    public void ConvertStageData(string[] _Iteminfo)
    {
        //int enchant_per_slot_count = 0;
        //int price_count = 0;
        //int enchant_price_count = 0;

        //for (int i = 0; i < _Iteminfo.Length; i++)
        //{
        //    if (i == BitConvert.Enum32ToInt<DataName>(DataName.UID))
        //    {
        //        m_ReinforceData.uid = Convert.ToInt32(_Iteminfo[i]);
        //    }
        //    else if (i >= BitConvert.Enum32ToInt<DataName>(DataName.ENCHANT_PERSENT) && i < BitConvert.Enum32ToInt<DataName>(DataName.PRICE))
        //    {
        //        m_ReinforceData.enchant_per_slot[enchant_per_slot_count++] = Convert.ToInt32(_Iteminfo[i]);
        //    }
        //    else if (i >= BitConvert.Enum32ToInt<DataName>(DataName.PRICE) && i < BitConvert.Enum32ToInt<DataName>(DataName.BUY))
        //    {
        //        m_ReinforceData.price[price_count++] = Convert.ToInt32(_Iteminfo[i]);
        //    }
        //    else if (i == BitConvert.Enum32ToInt<DataName>(DataName.BUY))
        //    {
        //        m_ReinforceData.buy_price = Convert.ToInt32(_Iteminfo[i]);
        //    }
        //    else if (i >= BitConvert.Enum32ToInt<DataName>(DataName.ENCHANT_PRICE) && i < BitConvert.Enum32ToInt<DataName>(DataName.GOLD))
        //    {
        //        m_ReinforceData.enchant_price[enchant_price_count++] = Convert.ToInt32(_Iteminfo[i]);
        //    }
        //    else if (i == BitConvert.Enum32ToInt<DataName>(DataName.GOLD))
        //    {
        //        m_ReinforceData.Minute_gold = Convert.ToInt32(_Iteminfo[i]);
        //    }
        //    else if (i == BitConvert.Enum32ToInt<DataName>(DataName.ITEM_NAME))
        //    {
        //        m_ReinforceData.item_name = _Iteminfo[i];
        //    }
        //    else if (i == BitConvert.Enum32ToInt<DataName>(DataName.ITEM_COMMENT))
        //    {
        //        m_ReinforceData.item_comment = _Iteminfo[i];
        //    }
        //}
    }
}
