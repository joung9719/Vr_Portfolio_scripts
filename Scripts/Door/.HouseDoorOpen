using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class HouseDoorOpen : MonoBehaviour
{
     private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RightHand"))
        {
          
            StartCoroutine(OpenAndChangeScene());
        }
    }

    private IEnumerator OpenAndChangeScene()
    {
        yield return new WaitForSeconds(1f); // 1초 대기
        SceneManager.LoadScene("HouseLoading");
    }

}
