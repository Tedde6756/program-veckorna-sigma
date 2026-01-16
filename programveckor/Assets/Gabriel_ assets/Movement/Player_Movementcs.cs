using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 5f;

    [Header("Sound Settings")]
    public AudioSource movementSound; // Footstep or movement sound

    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Setup movement sound
        if (movementSound != null)
        {
            movementSound.loop = true;      // Loop while moving
            movementSound.playOnAwake = false; // Don't play automatically
        }
    }

    void Update()
    {
        // Get input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Normalize diagonal movement
        movement = movement.normalized;

        // Handle animation
        bool isMoving = movement != Vector2.zero;
        animator.SetBool("IsRunning", isMoving);

        if (isMoving)
        {
            animator.SetFloat("MoveX", movement.x);
            animator.SetFloat("MoveY", movement.y);
        }

        // Flip sprite left/right
        if (movement.x > 0)
            spriteRenderer.flipX = false;
        else if (movement.x < 0)
            spriteRenderer.flipX = true;

        // Handle movement sound
        if (movementSound != null)
        {
            if (isMoving && !movementSound.isPlaying)
                movementSound.Play();
            else if (!isMoving && movementSound.isPlaying)
                movementSound.Pause();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
