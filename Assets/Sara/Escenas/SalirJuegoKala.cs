using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirJuegoKala : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene(PlayerPrefs.GetString("EscenaQueCargaJuego"));
        Time.timeScale = 1;
    }
	
}
