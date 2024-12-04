using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;

    void Start()
    {
        //SpawnTarget();
    }

    void SpawnTarget()
    {
        GameObject target = TargetPool.Instance.GetTarget();
        target.transform.position = spawnPoint.position;
    }
}
