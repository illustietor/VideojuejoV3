using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarMinijuegos : MonoBehaviour {

    public Object escenaDestino;

	public void CargarEscenaConReferenciaActual()
    {
        PlayerPrefs.SetString("EscenaQueCargaJuego", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(escenaDestino.name);
    }
}
