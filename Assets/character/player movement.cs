using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 7f;

    private Rigidbody2D rb;
    private Animator animator;       // AJOUT ANIMATION
    private SpriteRenderer sr;       // AJOUT ANIMATION

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();       // AJOUT ANIMATION
        sr = GetComponent<SpriteRenderer>();       // AJOUT ANIMATION
    }

    private void Update()
    {
        // Axe X : D = +1, Q = -1
        float x = 0f;
        if (Input.GetKey(KeyCode.D)) x = 1f;
        if (Input.GetKey(KeyCode.Q)) x = -1f;

        rb.linearVelocity = new Vector2(x * speed, rb.linearVelocity.y);

        // Axe Y : Espace = +1 (une impulsion vers le haut)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        // ----- AJOUT ANIMATION (le code ci-dessus est inchangé) -----
        animator.SetBool("IsRunning", x != 0f);

        if (x > 0f) sr.flipX = false;
        else if (x < 0.1f) sr.flipX = true;
    }
}