using UnityEngine;

public class ChefController : MonoBehaviour
{
    public Animator animator;
    public Rigidbody manzana;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("Stabbing");

            manzana.AddForce(Vector3.right * 10f, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.Play("Victory");
        }
    }
}