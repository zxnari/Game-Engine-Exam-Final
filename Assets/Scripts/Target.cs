using UnityEngine;

public class Target : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 1000.0f;
    // Update is called once per frame
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        rb.linearVelocityX = speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            speed = -speed;
        }
    }
}
