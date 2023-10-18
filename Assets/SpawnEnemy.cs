using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public float SPI = 5F;
    public GameObject Enemy1;
    public float despawnTime = 5F;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        SPI -= Time.deltaTime;
        if (SPI < 0)
        {
            float num = Random.Range(3, 5);
            Vector3 EnemyStart = new Vector3(num, 7, 0);
            GameObject spawnedObject = Instantiate(Enemy1, EnemyStart, transform.rotation);
            Destroy(spawnedObject, despawnTime);
            SPI = 3f;

        }
    }

}
