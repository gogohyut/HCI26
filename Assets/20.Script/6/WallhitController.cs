using UnityEngine;

public class WallhitController : MonoBehaviour
{
    public ParticleSystem effect;

    private void OnCollisionEnter(Collision collision)
    {
        if (effect == null) return;

        ContactPoint contact = collision.contacts[0];
        effect.transform.position = contact.point;
        effect.transform.rotation = Quaternion.LookRotation(-contact.normal);
        effect.Play();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
}