using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WalkLoadingManager : MonoBehaviour
{
    private static string nextScene;

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("WalkLoading"); // 로딩씬
    }

    void Start()
    {
        StartCoroutine(LoadWalkScene());
    }

    IEnumerator LoadWalkScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Walk"); // 실제 목적지
    }
}
