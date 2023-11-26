using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HBMove : MonoBehaviour
{
    private float speed = 10;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}