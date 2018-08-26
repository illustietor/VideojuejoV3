using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirJuego : MonoBehaviour {

    public Object escenaALaQueSalir;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(0);
    }
}
