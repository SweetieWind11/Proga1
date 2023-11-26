using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NashorBulletMove : MonoBehaviour
{
    private float speed = 20;
    Vector3 direction = new Vector3(1, 0, 0);
    private float lifetime = 5f; // Tiempo de vida del objeto en segundos

    void Update()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime);

        lifetime -= Time.deltaTime;

        if (lifetime <= 0f)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}