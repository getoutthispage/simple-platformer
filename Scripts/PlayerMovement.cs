using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private float move;

    public float jump = 380f;

    public bool isJumping; 

    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(speed * move, rb.linearVelocity.y); 

        if (Input.GetButtonDown("Jump") && isJumping == false){

            rb.AddForce(new Vector2(rb.linearVelocity.x, jump));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
