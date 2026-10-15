using UnityEngine;

public class ShowPosition : MonoBehaviour
{
    public Color coloer = Color.yellow;
    public float radius = 0.5f;
    void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawSphere(transform.position, radius);
    }
 
}
