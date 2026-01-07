using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BathroomLoadingManager : MonoBehaviour
{
    private static string nextScene;

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("BathroomLoading"); // 로딩씬
    }

    void Start()
    {
        StartCoroutine(LoadBathroomScene());
    }

    IEnumerator LoadBathroomScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Bathroom"); // 실제 목적지
    }
}
