using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public float SPI = 4F;
    public GameObject Enemy1;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        SPI -= Time.deltaTime;
        if (SPI < 0)
        {
            float num = Random.Range(-3, 6);
            Vector3 EnemyStart = new Vector3(10, num, 0);
            Instantiate(Enemy1, EnemyStart, transform.rotation);
            SPI = 1F;
        }
    }

}
