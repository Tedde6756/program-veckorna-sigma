using UnityEngine;

public class Player_movement : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(0, 0);
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 8.35)
            {
                rb.linearVelocity = new Vector2(3, 0);
            }
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -8.35)
            {
                rb.linearVelocity = new Vector2(-3, 0);
            }
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > -4.675)
            {
                rb.linearVelocity = new Vector2(0, -3);
            }
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < 4.675)
            {
                rb.linearVelocity = new Vector2(0, 3);
            }
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (transform.position.y < 4.675)
                {
                    rb.linearVelocity = new Vector2(0, 3);
                }

                rb.linearVelocity = new Vector2(-2.5F, 2.5F);
            }

        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (transform.position.y < 4.675)
                {
                    rb.linearVelocity = new Vector2(0, 3);
                }

                rb.linearVelocity = new Vector2(2.5F, 2.5F);
            }

        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (transform.position.y > -4.675)
                {
                    rb.linearVelocity = new Vector2(0, -3);
                }
                 
                rb.linearVelocity = new Vector2(2.5F, -2.5F);
            }

        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (transform.position.y > -4.675)
                {
                    rb.linearVelocity = new Vector2(0, -3);
                }

                rb.linearVelocity = new Vector2(-2.5F, -2.5F);
            }

        }
    }
}
