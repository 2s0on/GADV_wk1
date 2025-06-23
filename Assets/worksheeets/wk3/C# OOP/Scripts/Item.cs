using UnityEngine;

public class Item : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Explodable>()?.Explode();
        }
    }
}