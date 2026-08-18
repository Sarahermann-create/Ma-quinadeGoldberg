using UnityEngine;

public class RuedaPorBola : MonoBehaviour
{
    public float fuerzaGiro = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {
            rb.AddTorque(Vector3.forward * fuerzaGiro, ForceMode.Impulse);
        }
    }
}