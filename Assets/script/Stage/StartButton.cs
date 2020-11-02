using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void Load2Stage()
    {
        LoadingSceneManager.nextScene = "Loading";
        SceneManager.LoadScene("Loading");
    }
}
