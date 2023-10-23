using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyfunction : MonoBehaviour
{
    private float speed = 10;

    Vector3 direction = new Vector3(-1, 0, 0);

    private Puntos puntos;

    private MovementeCube vidas;
    private void Start()
    {
        puntos = FindObjectOfType<Puntos>();
    }
    void Update()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //"puntos.puntos = puntos.puntos + 1;" Se abrevia con ++ u si quiero abreviar una suma mayor +=5 ademas solo se usa si la variable es publica
        if (collision.gameObject.tag == "PRP")
        {
            puntos.AddPoints(1);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            vidas.scorev(1);
        }
        Destroy(gameObject);
    }

}
