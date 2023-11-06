using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float speed;
    public float SPI = 5f; //SPI es una abreviación de Spawn Interval
    private float TSP; //Este es una abreviación de TimeSinceSpawn
    public int life = 3;
    
    void Start()
    {
        TSP = 0f;
    }

    void Update()
    {
        TSP += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SPO();
            TSP = 0f;
        }
    }
    void SPO()
    {
       GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        Destroy(spawnedObject, SPI);
    }
    public void Lifes()
    {
        life = life - 1;
        if (life == 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }
}
