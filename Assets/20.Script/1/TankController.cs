using UnityEngine;

[CreateAssetMenu(fileName = "TankController", menuName = "Scriptable Objects/TankController")]
public class TankController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float rotateSpeed = 2f;
    float move;
    float rotate;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
        void Update()
        {
            move = Input.GetAxis("Vertical");
            rotate = Input.GetAxis("Horizontal");

            if(Mathf.Abs(move) > 0.1f)
            {
                Move();
            }
        }

        void Move()
        {
            Vector3 moveDir = transform.forward * move * moveSpeed * Time.deltaTime;
            rb.MovePosition(rb.position + moveDir);
        }

}
