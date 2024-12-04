using UnityEngine;

public class Snowflakes : MonoBehaviour
{
    public SnowflakePool SnowflakePool;
    public GameObject SnowflakePrefab;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SnowflakePool.ReturnSnowflake(gameObject, SnowflakePrefab);
        }
    }
}
