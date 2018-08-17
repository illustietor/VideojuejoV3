using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptReiniciarJuego : MonoBehaviour {

    public Object escenaReiniciar;

	public void ReinicarEscena ()
    {
        SceneManager.LoadScene(escenaReiniciar.name);
        Time.timeScale = 1;
    }
}
