using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Shoot()
    {
        rb.rotation = Quaternion.LookRotation(transform.forward);
        rb.AddRelativeForce(Vector3.forward * 1200.0f);
    }
}
