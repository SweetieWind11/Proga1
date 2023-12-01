using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//para hacer la barra de vida use este tutorial https://www.youtube.com/watch?v=VtAzpUj_nNk
public class BossVida : MonoBehaviour

{
    private bool isMoving = true;
    public float vida = 100;
    public Slider BossBar;
    private Puntos puntos;
    public float Speed = 2f;
    private float SPI = 0F;
    private float SPI2 = 0F;
    public GameObject CanonRed;
    public GameObject ArrowRed;

    void Start()
    {
        puntos = FindObjectOfType<Puntos>();

    }

    void Update()
    {

        BossBar.value = vida;
        if (vida <= 0)
        {
            Destroy(gameObject);
            death();
        }
        Move();
        if (vida <= 50)
        {


            SPI -= Time.deltaTime;
            if (SPI < 0)
            {
                float num = Random.Range(-3, 6);
                Vector3 EnemyStart = new Vector3(5, num, 0);
                Instantiate(CanonRed, EnemyStart, transform.rotation);
                SPI = 1F;
            }
        }
        if (vida <= 70)
        {
            SPI2 -= Time.deltaTime;
            if ( SPI2 <= 0)
            {
                float num = Random.Range(-4, 8);
                Vector3 EnemyStart = new Vector3(5, num, 0);
                Instantiate(ArrowRed, EnemyStart, transform.rotation);
                SPI2 = 1.5F;
            }
        }
    }

    private void Move()
    {
        if (puntos.PuntosActuales() >= 70)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(7, 0, 0), Speed * Time.deltaTime);
            if (transform.position == new Vector3(7, 0, 0))
            {
                isMoving = false;
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PRP")
        {
            vida = vida - 0.5f;
        }
    }
    public float vidap()
    {
        return vida;
    }
    void death()
    {
        if (vida <= 0)
        {
            puntos.AddPoints(30);

        }
    }
}
