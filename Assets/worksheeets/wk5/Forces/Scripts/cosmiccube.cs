using UnityEngine;

public class cosmiccube : MonoBehaviour
{
    private Renderer rend;
    private Color originalColor;
    public Color collisionColor = Color.green;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;

        // Disable gravity if not already
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null) rb.useGravity = false;
    }

    void Update()
    {
        // Rotate constantly on all axes
        transform.Rotate(new Vector3(45, 45, 45) * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        rend.material.color = collisionColor; // Change to green
    }

    void OnCollisionExit(Collision collision)
    {
        rend.material.color = originalColor; // Change back to red
    }
}