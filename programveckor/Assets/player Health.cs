using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;
  

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
      
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health < 0)
        {
            Destroy(gameObject);
        }
    }
}
