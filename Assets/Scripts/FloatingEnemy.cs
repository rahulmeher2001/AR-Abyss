using UnityEngine;
using UnityEngine.SceneManagement;

public class FloatingEnemy : MonoBehaviour
{
    public Transform player; // Assign the player GameObject in the Inspector
    public float moveSpeed = 3.0f; // Speed at which the enemy moves

    private void Start()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
    void Update()
    {
        if (player != null)
        {
            // Calculate the direction from the enemy to the player
            Vector3 directionToPlayer = player.position - transform.position;

            // Normalize the direction to get a unit vector
            directionToPlayer.Normalize();

            // Move the enemy towards the player
            transform.Translate(directionToPlayer * moveSpeed * Time.deltaTime, Space.World);

            // Rotate the enemy to always face the player
            transform.LookAt(player);

            if (Vector3.Distance(player.position, transform.position)>15)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}

