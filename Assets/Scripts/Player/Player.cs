using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveDistance = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); //left right
        float moveY = Input.GetAxis("Vertical");   //up down

        Vector2 movement = new Vector2(moveX, moveY).normalized * moveDistance;

        rb.velocity = movement;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Snowflake"))
        {
            Destroy(collision.gameObject);
        }
    }
}