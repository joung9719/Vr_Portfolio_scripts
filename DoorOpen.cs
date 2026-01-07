using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WalkDoorOpen : MonoBehaviour
{
    public float walkOpenAngle = 90f;   // 열릴 각도
    public float walkSpeed = 2f;        // 열리는 속도
    public string walkNextScene;        // 전환할 씬 이름

    private bool isWalkOpen = false;
    private Quaternion walkInitialRotation;

    void Start()
    {
        walkInitialRotation = transform.rotation;
    }

    void Update()
    {
        Quaternion targetRotation = isWalkOpen
            ? walkInitialRotation * Quaternion.Euler(0, walkOpenAngle, 0)
            : walkInitialRotation;

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            Time.deltaTime * walkSpeed
        );
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RightHand") && !isWalkOpen)
        {
            isWalkOpen = true;
            StartCoroutine(OpenAndChangeScene());
        }
    }

    private IEnumerator OpenAndChangeScene()
    {
        yield return new WaitForSeconds(1f); // 1초 대기
        SceneManager.LoadScene("WalkLoading");
    }
}
