using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Puntos : MonoBehaviour
{
    private TMP_Text textComponent;
    private int puntos = 0;
    private void Start()
    {
        textComponent = GetComponent<TMP_Text>();

        //para sacar otro comomente de otro objeto en caso de que la variable sea "private GameObject num;" el,
        //"textComponent = num.GetComponent<TMP_Text>();" seria el codigo correcto para que funcione
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = "Puntos: " + puntos;
        if (puntos >= 100)
        {
            SceneManager.LoadScene(3);
        }
    }
    public void AddPoints(int cpts)
    {
        puntos = puntos + cpts;
    }
    public int PuntosActuales()
    {
        return puntos;
    }
}
