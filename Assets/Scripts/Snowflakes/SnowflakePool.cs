using System.Collections.Generic;
using UnityEngine;

public class SnowflakePool : MonoBehaviour
{
    public GameObject[] SnowflakePrefabs;
    public int initialPoolSize = 10; 

    private Dictionary<GameObject, Queue<GameObject>> SnowflakePools = new Dictionary<GameObject, Queue<GameObject>>();

    void Start()
    {
        foreach (var SnowflakePrefab in SnowflakePrefabs)
        {
            Queue<GameObject> pool = new Queue<GameObject>();
            for (int i = 0; i < initialPoolSize; i++)
            {
                GameObject Snowflake = Instantiate(SnowflakePrefab);
                Snowflake.SetActive(false);
                pool.Enqueue(Snowflake);
            }
            SnowflakePools[SnowflakePrefab] = pool;
        }
    }

    public GameObject GetSnowflake(GameObject SnowflakePrefab)
    {
        if (SnowflakePools.ContainsKey(SnowflakePrefab) && SnowflakePools[SnowflakePrefab].Count > 0)
        {
            GameObject Snowflake = SnowflakePools[SnowflakePrefab].Dequeue();
            Snowflake.SetActive(true);
            return Snowflake;
        }
        else
        {
            return Instantiate(SnowflakePrefab);
        }
    }

    public void ReturnSnowflake(GameObject Snowflake, GameObject SnowflakePrefab)
    {
        Snowflake.SetActive(false);
        SnowflakePools[SnowflakePrefab].Enqueue(Snowflake);
    }
}
