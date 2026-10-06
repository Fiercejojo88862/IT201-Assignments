using UnityEngine;
using UnityEngine.SceneManagement; // Reloads scenes

public class KillPlane : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Check if the object falling through is the player
        if (other.CompareTag("Player"))
        {
            // Reload the current active scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}