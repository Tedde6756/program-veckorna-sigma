using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    // The name of the scene to load
    public string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player entered the teleporter
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}