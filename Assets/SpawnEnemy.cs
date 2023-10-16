using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public float SPI = 5f;
    public GameObject Enemy1;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float num = Random.Range(3, 5);
        Vector3 EnemyStart = new Vector3(num, 7, 0);
        GameObject spawnedObject = Instantiate(Enemy1, transform.position, Quaternion.identity);

    }
}
