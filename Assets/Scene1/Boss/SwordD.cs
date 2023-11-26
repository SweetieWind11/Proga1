using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordD : MonoBehaviour
{
    private float speed = 10f;
    private Vector3 direction;
    private Spawn Lifes;
    private void Start()
    {
        Lifes = FindObjectOfType<Spawn>();
    }
    void Update()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Lifes.Lifes();
        }else if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "PRP" || collision.gameObject.tag == "HBuff" || collision.gameObject.tag == "NBuff")
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
}