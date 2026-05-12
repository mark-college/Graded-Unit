using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpd = 5f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 move = new Vector2(x, y).normalized * moveSpd;

        rb.linearVelocity = move;
    }
}