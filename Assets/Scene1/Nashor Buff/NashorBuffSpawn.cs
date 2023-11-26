using System;
using System.Collections;
using UnityEngine;

public class NashorBuffSpawn : MonoBehaviour
{
    public float spawnInterval = 30f; 
    public float buffDuration = 10f;
    public GameObject NashorBuff;

    private void Start()
    {
        
    }
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
        Vector3 NashorStart = new Vector3(10f, randomY, 0f);

        GameObject buffInstance = Instantiate(NashorBuff, NashorStart, Quaternion.identity);

        Destroy(buffInstance, buffDuration);
    }

    void ResetSpawnInterval()
    {
        spawnInterval = 30f;
    }
}