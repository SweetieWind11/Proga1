using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeFollow : MonoBehaviour
{
    private Spawn Lifes;
    private float speed = 10;

    Vector3 direction = new Vector3(-1, 0, 0);

    private Puntos puntos;

    private MovementeCube vidas;
    private void Start()
    {
        Lifes = FindObjectOfType<Spawn>();
        puntos = FindObjectOfType<Puntos>();
    }
    void Update()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Lifes.Lifes();
        }
        else if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "HBuff" || collision.gameObject.tag == "NBuff")
        {

        }
        else
        {
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }

}
