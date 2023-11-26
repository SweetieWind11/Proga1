using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//bibliotecas que consulte
// https://docs.unity3d.com/ScriptReference/WaitForSeconds.html
// https://docs.unity3d.com/ScriptReference/MonoBehaviour.StartCoroutine.html
public class SwordManager : MonoBehaviour
{
    public GameObject Sword;

    private BossVida vida;
    private Coroutine swordLaunchsCoroutine;

    void Start()
    {
        vida = FindObjectOfType<BossVida>();
        StartSwordLaunchsCoroutine();
    }

    void Update()
    {
        if (swordLaunchsCoroutine == null && vida.vidap() <= 99)
        {
            StartSwordLaunchsCoroutine();
        }
    }

    void StartSwordLaunchsCoroutine()
    {
        if (swordLaunchsCoroutine != null)
        {
            StopCoroutine(swordLaunchsCoroutine);
        }

        swordLaunchsCoroutine = StartCoroutine(SwordLaunchs());
    }

    IEnumerator SwordLaunchs()
    {
        while (vida.vidap() <= 99)
        {
            SwordLaunch(new Vector3(-8f, 0f, 0f));
            SwordLaunch(new Vector3(-5f, 6f, 0f));
            SwordLaunch(new Vector3(-5f, -3.5f, 0f));

            yield return new WaitForSeconds(2f);

            SwordLaunch(new Vector3(-8f, -2.5f, 0f));
            SwordLaunch(new Vector3(-8f, 5.3f, 0f));

            yield return new WaitForSeconds(2f);
        }
        swordLaunchsCoroutine = null;
    }

    void SwordLaunch(Vector3 direction)
    {
        GameObject lanza = Instantiate(Sword, new Vector3(7f, 0f, 0f), Quaternion.identity);
        lanza.GetComponent<SwordD>().SetDirection(direction);
    }
}