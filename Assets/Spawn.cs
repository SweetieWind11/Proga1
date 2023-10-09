using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float speed;

    public Vector3 spawnPoint = new Vector3(0, 0, 0);
    
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn, spawnPoint, Quaternion.identity)
        }
    }
}
