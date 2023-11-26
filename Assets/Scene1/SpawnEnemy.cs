using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private float SPI = 4F;
    public GameObject Enemy1;
    public GameObject Enemy2;
    private float SPIE2 = 10f;
    private bool BossCheck;
    private Puntos puntos;
    public GameObject Enemy3;

    void Start()
    {
        BossCheck = false;
        puntos = FindObjectOfType<Puntos>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BossCheck == false)
        {
            SPI -= Time.deltaTime; SPIE2 -= Time.deltaTime;
            if (SPI < 0)
            {
                float num = Random.Range(-3, 6);
                Vector3 EnemyStart = new Vector3(10, num, 0);
                Instantiate(Enemy1, EnemyStart, transform.rotation);
                SPI = 1F;
            }
            else if (SPIE2 < 0)
            {
                float num = Random.Range(-4, 8);
                Vector3 EnemyStart = new Vector3(10, num, 0);
                Instantiate(Enemy2, EnemyStart, transform.rotation);
                SPIE2 = 4F;
            }
            if (puntos.PuntosActuales() >= 70)
            {
                BossCheck = true;
            }
        }
    }

}
