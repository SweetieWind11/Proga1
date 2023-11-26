using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HBSpawn : MonoBehaviour
{
    public float spawnInterval = 20f;
    public float buffDuration = 10f;
    public GameObject HullBreaker;

    void Update()
    {
        spawnInterval -= Time.deltaTime;

        if (spawnInterval < 0)
        {
            SpawnNashorBuff();
            ResetSpawnInterval();
        }
    }

    void SpawnNashorBuff()
    {
        float randomY = UnityEngine.Random.Range(-3f, 6f);
        Vector3 HullStart = new Vector3(10f, randomY, 0f);

        GameObject buffInstance = Instantiate(HullBreaker, HullStart, Quaternion.identity);

        Destroy(buffInstance, buffDuration);
    }

    void ResetSpawnInterval()
    {
        spawnInterval = 20f;
    }
}