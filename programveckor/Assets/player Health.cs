using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 10;
    private int currentHP;

    public HealthBar healthBar;

    // Reference to GameOver UI script
    public GameOverUI gameOverUI;

    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int amount)
    {
        currentHP -= amount;

        if (currentHP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {

        // Show Game Over UI
        if (gameOverUI != null)
        {
            gameOverUI.ShowGameOver();
        }

        // Optionally disable player movement
        gameObject.SetActive(false);
    }
}