using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] AudioClip shotSound;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioManager.Instance.PlaySFX(shotSound);
            SpawnBullet(new Vector2(0, 10f));
        }
    }

   public void SpawnBullet(Vector2 velocity)
    {
        GameObject bulletObject = BulletPool.Instance.GetBullet();
        bulletObject.transform.position = spawnPoint.position;

        Bullet bullet = bulletObject.GetComponent<Bullet>();
        bullet.Velocity = velocity;
    }
}