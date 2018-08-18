using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Personajes1Conversacion : MonoBehaviour {
    public Flowchart conversacion;
    bool triggering;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggering == true)
        {
            conversacion.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggering = true;
    }

    private void OnTriggerExit(Collider other)
    {
        triggering = false;
    }
}
