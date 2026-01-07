using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DogName : MonoBehaviour
{
    public string NameNextScene;

    public void LoadNameScene()
    {
        StartCoroutine(OpenHouseLoadingScene());
    }

    private IEnumerator OpenHouseLoadingScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("HouseLoading");
    }
    
}
