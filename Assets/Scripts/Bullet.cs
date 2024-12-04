using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 Velocity { get; set; }

    private void Update()
    {
        transform.position += (Vector3)(Velocity * Time.deltaTime);
        if (transform.position.y > 10f)
        {
            BulletPool.Instance.ReturnBullet(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            BulletPool.Instance.ReturnBullet(this.gameObject);
            Destroy (collision.gameObject);
            Debug.Log("You Win!");
        }
    }
}