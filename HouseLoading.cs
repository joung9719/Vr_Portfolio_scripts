using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HouseLoading : MonoBehaviour
{
    // Start is called before the first frame update
   private static string nextScene;

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("HouseLoading"); // 로딩씬
    }

    void Start()
    {
        StartCoroutine(LoadHouseScene());
    }

    IEnumerator LoadHouseScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("House"); // 실제 목적지
    }
}
