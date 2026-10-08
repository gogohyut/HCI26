using UnityEngine;

public class ShellController : MonoBehaviour
{
    public GameObject explosionPrefab; // 폭발 파티클 프리팹 (선택 사항)
    public float maxLifeTime = 3f;      // 충돌하지 않아도 사라지는 제한 시간

    void Start()
    {
        // 일정 시간이 지나면 자동 삭제
        Destroy(gameObject, maxLifeTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // 폭발 이펙트가 있다면 생성
        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
        }

        // 포탄 삭제
        Destroy(gameObject);
    }
}