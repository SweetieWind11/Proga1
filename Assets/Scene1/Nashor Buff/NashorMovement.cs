using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NashorMovement : MonoBehaviour
{
    private float speed = 10;
    Vector3 direction = new Vector3(-1, 0, 0);

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
