using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBullet(new Vector2(0, 10f));
        }
    }

    void SpawnBullet(Vector2 velocity)
    {
        GameObject bulletObject = BulletPool.Instance.GetBullet();
        bulletObject.transform.position = spawnPoint.position;

        Bullet bullet = bulletObject.GetComponent<Bullet>();
        bullet.Velocity = velocity;
    }
}