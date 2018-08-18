using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Hernesto : MonoBehaviour {
    public Flowchart hernestoBueno;
    public Flowchart hernestoNeutro;
    public Flowchart hernestoMalo;
    public Flowchart hernesto;

    bool personajeActivado, triggering, activado;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.E) && triggering)
        {
            activado = true;
            if (!personajeActivado)
            {
                hernesto.gameObject.SetActive(true);
            }

            else
            {

                if (hernesto.GetBooleanVariable("finalBueno"))
                {
                    hernestoBueno.gameObject.SetActive(true);
                }

                else if (hernesto.GetBooleanVariable("finalNeutro"))
                {
                    hernestoNeutro.gameObject.SetActive(true);
                }

                else if (hernesto.GetBooleanVariable("finalMalo"))
                {
                    hernestoMalo.gameObject.SetActive(true);
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
