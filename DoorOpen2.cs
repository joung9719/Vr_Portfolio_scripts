using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BathroomDoorOpen : MonoBehaviour
{
    public float bathroomOpenAngle = 90f;   // 열릴 각도
    public float bathroomSpeed = 2f;        // 열리는 속도
    public string bathroomNextScene;        // 전환할 씬 이름

    private bool isBathroomOpen = false;
    private Quaternion bathroomInitialRotation;

    void Start()
    {
        bathroomInitialRotation = transform.rotation;
    }

    void Update()
    {
        Quaternion targetRotation = isBathroomOpen
            ? bathroomInitialRotation * Quaternion.Euler(0, bathroomOpenAngle, 0)
            : bathroomInitialRotation;

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            Time.deltaTime * bathroomSpeed
        );
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RightHand") && !isBathroomOpen)
        {
            isBathroomOpen = true;
            StartCoroutine(OpenAndChangeScene());
        }
    }

    private IEnumerator OpenAndChangeScene()
    {
        yield return new WaitForSeconds(1f); // 1초 대기
        SceneManager.LoadScene("BathroomLoading");
    }
}
