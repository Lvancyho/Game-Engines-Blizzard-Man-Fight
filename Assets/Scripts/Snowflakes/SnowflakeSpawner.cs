using UnityEngine;

public class SnowflakeSpawner : MonoBehaviour
{
    public SnowflakePool SnowflakePool;
    public float spawnInterval = 2f;
    public float spawnRangeX = 7f;
    public float spawnRangeY = 0f;
    private GameObject SnowflakePrefab;

    void Start()
    {
        InvokeRepeating("SpawnSnowflake", 2f, spawnInterval);
    }

    void SpawnSnowflake()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-2, 2f), Random.Range(-7f, 7f));


        GameObject Snowflake = SnowflakePool.GetSnowflake(SnowflakePrefab);
        Snowflake.transform.position = spawnPosition;
    }
}
