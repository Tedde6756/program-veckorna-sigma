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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 2)
            {
                rb.linearVelocity = new Vector2(3, 0);
            }

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -2)
            {
                rb.linearVelocity = new Vector2(-3, 0);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 2)
            {
                rb.linearVelocity = new Vector2(3, 0);
            }

        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -2)
            {
                rb.linearVelocity = new Vector2(-3, 0);
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.x < 2)
            {
                rb.linearVelocity = new Vector2(0, 3);
            }

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.x < 2)
            {
                rb.linearVelocity = new Vector2(0, 3);
            }

        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.x < 2)
            {
                rb.linearVelocity = new Vector2(0, -3);
            }

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.x < 2)
            {
                rb.linearVelocity = new Vector2(0, -3);
            }

        }
    }
}
