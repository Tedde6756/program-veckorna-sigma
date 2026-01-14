using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    int maxHealth = 3;
    public Image healthbar;
    int health;
    public float Health;

    [SerializeField]
    AudioClip hurtSound;

    AudioSource audioSource;

    [SerializeField]
    string gameOverSceneName;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void Hurt(int amount)
    {

        if (audioSource != null && hurtSound != null)
        {
            audioSource.PlayOneShot(hurtSound);
        }

        health -= amount;
        if (health <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(gameOverSceneName);
    }

    private void Update()
    {
        healthbar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
    }
}
