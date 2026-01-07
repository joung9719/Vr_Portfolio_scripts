using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainScenes : MonoBehaviour
{
    public string HouseNextScene;

    public void LoadHouseScene()
    {
        StartCoroutine(OpenNextScene());
    }

    private IEnumerator OpenNextScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("DogName");
    }
    
}
