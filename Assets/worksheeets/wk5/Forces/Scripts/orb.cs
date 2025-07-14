using UnityEngine;

public class orb : MonoBehaviour
{
    public float impulseStrength = 10f; // Set this in Inspector
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // Make sure gravity is off
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Apply impulse in the forward direction of the orb
            rb.AddForce(transform.forward * impulseStrength, ForceMode.Impulse);
        }
    }
}
