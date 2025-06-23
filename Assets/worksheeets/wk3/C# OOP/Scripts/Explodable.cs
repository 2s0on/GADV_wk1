using UnityEngine;

    public class Explodable : MonoBehaviour
    {
        public void Explode()
        {
            Debug.Log("Boom!");
            Destroy(gameObject);
        }
    }


