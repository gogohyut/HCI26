using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 20f;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = transform.forward * Time.deltaTime * speed;
        rb.MovePosition(rb.position + moveDir);
    }
    private void OnCollisionEnter(Collision collision)
    {
        {
            Destroy(gameObject);
        }
    }
}
