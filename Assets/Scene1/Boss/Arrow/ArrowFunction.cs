using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFunction : MonoBehaviour
{
    private Spawn Lifes;
    private float speed = 10f;
    private GameObject Objective;
    private bool isMoving = true;

    private Puntos puntos;

    void Start()
    {
        Lifes = FindObjectOfType<Spawn>();
        puntos = FindObjectOfType<Puntos>();
        Objective = GameObject.FindGameObjectWithTag("Player");

        RotateTowardsObjective();
    }

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PRP" || collision.gameObject.tag == "enemy")
        {

        }else if (collision.gameObject.tag == "Player")
        {
            Lifes.Lifes();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void RotateTowardsObjective()
    {
        if (Objective != null)
        {
            Vector3 directionToObjective = Objective.transform.position - transform.position;
            float angle = Mathf.Atan2(directionToObjective.y, directionToObjective.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }
    }
}