using UnityEngine;
using UnityEngine.SceneManagement;

public class RaycastToHome : MonoBehaviour
{
    public float rayDistance = 5f;           // 레이 길이
    public LayerMask interactLayer;          // 감지할 레이어
    public LineRenderer lineRenderer;        // 빔 시각화 (선택)

    void Start()
    {
        if (lineRenderer != null)
        {
            lineRenderer.positionCount = 2;  // 꼭 필요!
        }
    }

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayDistance, interactLayer))
        {
            // 레이 표시
            if (lineRenderer != null)
            {
                lineRenderer.SetPosition(0, transform.position);
                lineRenderer.SetPosition(1, hit.point);
            }

            // 집 입구에 닿았을 때
            if (hit.collider.CompareTag("HouseIn") && Input.GetButtonDown("Fire1"))
            {
                SceneManager.LoadScene("HouseLoading"); // 로딩씬으로 전환
            }
        }
        else
        {
            // 레이가 아무것도 안 맞으면 끝까지 그리기
            if (lineRenderer != null)
            {
                lineRenderer.SetPosition(0, transform.position);
                lineRenderer.SetPosition(1, transform.position + transform.forward * rayDistance);
            }
        }
    }
}
