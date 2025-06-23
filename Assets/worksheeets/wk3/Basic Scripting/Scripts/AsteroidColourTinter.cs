using UnityEngine;

public class AsteroidColourTinter : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    private bool isTinted = false;

    void Start()
    {
        // Get the SpriteRenderer component attached to this GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();
        // Store the original color of the sprite
        originalColor = spriteRenderer.color;
    }

    void Update()
    {
        // Check for user input to toggle the tint
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isTinted)
            {
                // Revert to the original color
                spriteRenderer.color = originalColor;
            }
            else
            {
                // Apply a new color tint
                spriteRenderer.color = Color.blue; // Change to any color you like
            }
            isTinted = !isTinted; // Toggle the state
        }
    }
}
