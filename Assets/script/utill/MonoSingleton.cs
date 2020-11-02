using System;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T instance;

    protected static void InstanceSetting()
    {
        instance = GetInstance_with_Hierarchy;
    }
    /// <summary>
    /// Search Type Object, Retrun Instance
    /// </summary>
    protected static T GetInstance_with_Hierarchy
    {
        get
        {
            if (instance == null)
            {

                //FindObjectOfType : 첫번째 활성화한 로드된 type 타입의 오브젝트를 반환합니다. Please note that this function is very slow. It is not recommended to use this function every frame.In most cases you can use the singleton pattern instead.
                if (FindObjectsOfType(typeof(T)).Length != 1)
                {

                    Debug.LogError(typeof(T) + " 타입의 오브젝트가 " +
                        FindObjectsOfType(typeof(T)).Length + "개 있음 " +
                        "<color=red><b>단일로 존재하지않고 있음!!</b></color> 즉시 프로세스를 종료하고 중복된 오브젝트를 찾아낼것!");
#if UNITY_EDITOR
                    EditorApplication.ExitPlaymode();
#endif                    
                }
                else
                {
                    instance = (T)FindObjectOfType(typeof(T));
                    if (instance == null)
                    {
                        Debug.LogError(typeof(T) + " 타입의 오브젝트를 찾을 수 없음. 원한다면 상속받은 클래스 내 인스턴스를 받는 메소드에 동적할당 구현을 하여 사용하도록!");
#if UNITY_EDITOR
                        EditorApplication.ExitPlaymode();
#endif       
                    }
                }
            }

            return instance;
        }
    }

    private void OnApplicationQuit()
    {
        instance = null;
    }
}