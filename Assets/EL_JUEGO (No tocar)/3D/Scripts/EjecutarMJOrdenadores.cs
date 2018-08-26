using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class EjecutarMJOrdenadores : MonoBehaviour {

    public Object minijuegoCargar;
    bool triggering;
    public Flowchart[] conversacionesNecesariasParaDesbloquearJuego;
    public Flowchart noTocar;
    public GameObject imagenJuegoOrdenador;
    bool juegoDesbloqueado;


    // Update is called once per frame
    void Update ()
    {
        if (ComprobarConversacionesDesbloqueo())
        {
            imagenJuegoOrdenador.gameObject.SetActive(true);
        }
            

        if (Input.GetKeyDown(KeyCode.E) && triggering)
        {
            if (ComprobarConversacionesDesbloqueo()) //Dar acceso al juego
            {
                CargarEscenaConReferenciaActual();
            }

            else //Dar pista de porque no tiene acceso al juego
            {
                noTocar.gameObject.SetActive(true);
            }
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

    bool ComprobarConversacionesDesbloqueo()
    {
        for (int i = 0; i < conversacionesNecesariasParaDesbloquearJuego.Length; i++)
        {
            if (conversacionesNecesariasParaDesbloquearJuego[i].gameObject.activeSelf == true) ;

            else
                return false;
        }

        return true;
    }

    public void CargarEscenaConReferenciaActual()
    {
        PlayerPrefs.SetString("EscenaQueCargaJuego", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(minijuegoCargar.name, LoadSceneMode.Additive);
    }

}
