using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptCargarEscena : MonoBehaviour {

    public int CargarEstaEscena;

    public void CargarEscena()
    {
        
        SceneManager.LoadScene(CargarEstaEscena);
    }

}
