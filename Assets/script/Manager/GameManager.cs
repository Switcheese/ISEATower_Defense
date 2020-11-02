using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    public readonly string m_gameScene = "IngameScene";
    public readonly string m_StartGame = "TitleScene";
    public readonly string m_LoadingScene = "Loading";

    private void Awake()
    {
        InstanceSetting();
    }

}
