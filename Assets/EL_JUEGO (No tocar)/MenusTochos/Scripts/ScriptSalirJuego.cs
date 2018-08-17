using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptSalirJuego : MonoBehaviour {

	public void VolverUltimaEscena ()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("EscenaQueCargaJuego"));
    }
}
