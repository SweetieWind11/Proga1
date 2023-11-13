using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class VidasScore : MonoBehaviour
{
    private Spawn spawnScript;
    private TMP_Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<TMP_Text>();
        spawnScript = FindObjectOfType<Spawn>();
    }
    void Update()
    {
        
          textComponent.text = "Vidas: " + spawnScript.life;
        
    }

}
