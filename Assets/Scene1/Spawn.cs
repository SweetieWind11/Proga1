using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public SpriteRenderer spriteRenderer;
    public GameObject boomObject;
    public float speed;
    private float SPI = 5f; // SPI es una abreviación de Spawn Interval
    public int life;
    private bool NShoot;
    private bool NashCheck;
    public SpriteRenderer NashSprite;
    private float NashCount;
    public GameObject NashBullet;
    private float lastSpawnTime = 0f;
    public float spawnCooldown = 3f;
    public SpriteRenderer HullSprite;
    private bool HBCheck;

    void Start()
    {
        NashSprite.enabled = false;
        HullSprite.enabled = false;
        NashCheck = false;
        NashCount = 6;
        NShoot = true;
        HBCheck = false;
    }


    void Update()
    {
        if (NShoot)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SPO();
            }
        }
        else if (NashCheck)
        {
            if (Input.GetKeyDown(KeyCode.Space) && CanSpawnN())
            {
                NBS();
            }
        }


        NashorBuff();
        HBBuff();
    }
    void NBS()
    {
        GameObject spawnedObject = Instantiate(NashBullet, transform.position, Quaternion.identity);
        Destroy(spawnedObject, SPI);
        lastSpawnTime = Time.time;
    }
    bool CanSpawnN()
    {
        return Time.time - lastSpawnTime >= spawnCooldown;
    }
    void SPO()
    {
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        Destroy(spawnedObject, SPI);
    }

    public void Lifes()
    {
        life--;
        if (life == 0)
        {
            spriteRenderer.enabled = false;
            boomObject.SetActive(true);
            boomObject.GetComponent<Animator>().SetTrigger("boom");
            Invoke("ChangeScene", .7f);
        }
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("NBuff"))
        {
            NashCheck = true;
        }
        else if (collision.gameObject.CompareTag("HBuff"))
        {
            HBCheck = true;
        }
    }

    public void NashorBuff()
    {
        if (NashCheck)
        {
            NashCount -= Time.deltaTime;

            spriteRenderer.enabled = false;
            NashSprite.enabled = true;
            NShoot = false;
            if (NashCount <= 0)
            {
                NashCheck = false;
                NashCount = 6f;
                spriteRenderer.enabled = true;
                NashSprite.enabled = false;
                NShoot = true;
            }
        }
    }
    public void HBBuff()
    {
        if (HBCheck)
        {
            spriteRenderer.enabled = false;
            HullSprite.enabled = true;
            if (life == 1)
            {
                life = life + 5;
            }
            else if (life == 2)
            {
                life = life + 4;
            }
            else if (life == 3)
            {
                life = life + 3;
            }
            else if (life == 4)
            {
                life = life + 2;
            }
            else if (life == 5)
            {
                life++;
            }
            HBCheck = false;
        }
        else if (HBCheck == false)
        {
            if (life <= 3)
            {
                spriteRenderer.enabled = true;
                HullSprite.enabled = false;
            }
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(2);
    }
}