using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptCargarEscena : MonoBehaviour {

    public Object CargarEstaEscena;

    public void CargarEscena()
    {
        
        SceneManager.LoadScene(CargarEstaEscena.name);
    }

}
