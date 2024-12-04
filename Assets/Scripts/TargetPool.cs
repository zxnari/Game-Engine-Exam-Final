using System.Collections.Generic;
using UnityEngine;

public class TargetPool : Singleton<TargetPool>
{
    [SerializeField] GameObject targetPrefab;
    Queue<GameObject> targetPool = new Queue<GameObject>();
    [SerializeField] int initialPoolSize = 1;

    private void Start()
    {
        for (int i = 0; i < initialPoolSize; i++)
        {
            GameObject target = Instantiate(targetPrefab);
            target.SetActive(false);
            targetPool.Enqueue(target);
        }
    }

    public GameObject GetTarget()
    {
        if (targetPool.Count > 0)
        {
            GameObject target = targetPool.Dequeue();
            target.SetActive(true);
            return target;
        }
        else
        {
            Debug.Log("No Targets! You Win!");
            Time.timeScale = 0;
            return null;
        }
    }

    public void ReturnTarget(GameObject target)
    {
        target.SetActive(false);
        targetPool.Enqueue(target);
    }
}