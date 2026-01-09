using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        Destroy(gameObject);   
       
        

        
        if (Collision.gameObject.TryGetComponent<enemyHP>(out enemyHP enemyComponent)) 
        {
            enemyComponent.Takedamage(1);
        }

        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
