using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 7f;
    [SerializeField] private Animator animator;

    private Rigidbody2D rb;
    private bool isGrounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Axe X : D = +1, Q = -1
        float x = 0f;
        if (Input.GetKey(KeyCode.D)) x = 1f;
        if (Input.GetKey(KeyCode.Q)) x = -1f;

        rb.linearVelocity = new Vector2(x * speed, rb.linearVelocity.y);

        // Animation de course
        if (x != 0f)
            animator.SetBool("isRunning", true);
        else
            animator.SetBool("isRunning", false);

        // Saut : Espace = une impulsion vers le haut (uniquement au sol)
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetBool("is jumping", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        animator.SetBool("is jumping", false);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false

    public class PlayerCoins : MonoBehaviour
    {
        [SerializeField] private CoinManager cm;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Coin"))
            {
                cm.coinCount++;
                Destroy(other.gameObject);
            }
        }
    }
}
}