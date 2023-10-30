using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementeCube : MonoBehaviour
{
    public float speed = 1f;
    private int vidas = 3;

    void Start()
    {
        
    }
 
    void Update()
    {
        Vector3 movimiento = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            movimiento.y = 10;
        } else if (Input.GetKey(KeyCode.S))
        {
            movimiento.y = -10;
        }
        move(movimiento);

    }
    void move(Vector3 direction)
    {
        transform.position += direction.normalized * speed * Time.deltaTime;
    }

}

