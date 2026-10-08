using UnityEngine;

public class CannonController : MonoBehaviour
{
    public GameObject shellPrefab; // 발사할 포탄 프리팹
    public Transform firePoint;    // 포탄이 생성될 위치 (포구 빈 오브젝트)
    public float launchForce = 30f; // 발사 힘

    void Update()
    {
        // 스페이스바를 누르면 발사
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        if (shellPrefab == null || firePoint == null) return;

        // 포탄 생성
        GameObject shellInstance = Instantiate(shellPrefab, firePoint.position, firePoint.rotation);

        // Rigidbody를 가져와 앞으로 힘 전달
        Rigidbody rb = shellInstance.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = firePoint.forward * launchForce;
        }
    }
}