using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 10;
    private int currentHP;

    // Reference to GameOver UI script
    public GameOverUI gameOverUI;

    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int amount)
    {
        currentHP -= amount;
        Debug.Log("Player took damage! Current HP: " + currentHP);

        if (currentHP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Player died!");

        // Show Game Over UI
        if (gameOverUI != null)
        {
            gameOverUI.ShowGameOver();
        }

        // Optionally disable player movement
        gameObject.SetActive(false);
    }
}