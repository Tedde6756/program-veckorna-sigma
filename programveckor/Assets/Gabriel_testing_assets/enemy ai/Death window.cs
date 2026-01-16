using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverScreen; // Drag your UI Image here

    void Start()
    {
        // Hide the Game Over screen at the start
        if (gameOverScreen != null)
            gameOverScreen.SetActive(false);
    }

    // Call this function when the player dies
    public void ShowGameOver()
    {
        if (gameOverScreen != null)
            gameOverScreen.SetActive(true);
    }
}