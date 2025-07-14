using UnityEngine;

public class beam : MonoBehaviour
{
    public float torqueStrength = 100f; // Adjust in Inspector
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.AddTorque(Vector3.up * torqueStrength, ForceMode.Impulse); // Clockwise (Y-axis)
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.AddTorque(-Vector3.up * torqueStrength, ForceMode.Impulse); // Anti-clockwise
        }
    }
}
