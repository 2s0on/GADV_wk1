using UnityEngine;

public class raycastplayer : MonoBehaviour
{
    void Start()
    {
        CheckLineOfSight(); // Call once at start
    }

    void CheckLineOfSight()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
        RaycastHit hit;

        foreach (GameObject enemy in enemies)
        {
            Vector3 direction = enemy.transform.position - transform.position;
            Debug.DrawRay(transform.position, direction, Color.red, 1f); // For visualization

            // Raycast towards the enemy
            if (Physics.Raycast(transform.position, direction, out hit, 30f))
            {
                // Check if the thing we hit *is* the enemy
                if (hit.collider.gameObject == enemy)
                {
                    enemy.GetComponent<Renderer>().material.color = Color.green; // Visible!
                }
                else
                {
                    enemy.GetComponent<Renderer>().material.color = Color.red; // Blocked!
                }
            }
        }
    }
}
