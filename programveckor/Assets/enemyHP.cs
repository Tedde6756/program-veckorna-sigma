using UnityEngine;

public class enemyHP : MonoBehaviour
{

    [SerializeField] float health, maxHealth = 3f;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float damageAmmount)
    {
        health -= damageAmmount;

        if(health <= 0)
        {
            Destroy(gameObject);   
    
        
        }
    }


}
