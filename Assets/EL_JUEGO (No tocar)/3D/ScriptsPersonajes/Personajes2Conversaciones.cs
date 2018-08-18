using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Personajes2Conversaciones : MonoBehaviour {
    public GameObject personaje;
    public Flowchart conversacion1;
    public Flowchart conversacion2;

    public bool personajeActivado;
    public bool triggering;
    bool activado;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggering == true)
        {
            activado = true;
            if (!personajeActivado)
            {
                conversacion1.gameObject.SetActive(true);
            }

            else
            {
                conversacion2.gameObject.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggering = true;  
    }

    private void OnTriggerExit(Collider other)
    {
        if (activado)
        {
            personajeActivado = true;
            triggering = false;
        }
    }
}