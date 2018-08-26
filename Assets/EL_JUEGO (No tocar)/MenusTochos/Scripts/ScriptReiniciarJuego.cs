using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptReiniciarJuego : MonoBehaviour {

    public int escenaReiniciar;

	public void ReinicarEscena ()
    {
        SceneManager.LoadScene(escenaReiniciar);
        Time.timeScale = 1;
    }
}
