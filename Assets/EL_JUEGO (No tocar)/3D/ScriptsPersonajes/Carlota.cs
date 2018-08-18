using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Carlota : MonoBehaviour {
    public Flowchart carlotaBueno;
    public Flowchart carlotaMalo;
    public Flowchart carlota;

    bool triggering;
    bool personajeActivado;
    bool activado;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && triggering)
        {
            activado = true;
            if (!personajeActivado)
            {
                carlota.gameObject.SetActive(true);
            }

            else
            {

                if (carlota.GetBooleanVariable("finalBueno"))
                {
                    carlotaBueno.gameObject.SetActive(true);
                }

                else if (carlota.GetBooleanVariable("finalMalo"))
                {
                    carlotaMalo.gameObject.SetActive(true);
                }
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
