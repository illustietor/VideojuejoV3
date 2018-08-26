using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Comprobador : MonoBehaviour
{
    public GameObject comprobador;
    public GameObject FPSController;
    public GameObject cameraControler;

    private void Update()
    {
        if (comprobador.activeInHierarchy == false)
        {
            FPSController.GetComponent<FirstPersonController>().enabled = true;
            cameraControler.GetComponent<CameraController>().enabled = true;
        }

        else
        {
            FPSController.GetComponent<FirstPersonController>().enabled = false;
            cameraControler.GetComponent<CameraController>().enabled = false;
            OnMouseDown();
        }
    }

    void OnMouseDown()
    {
        return;
    }
}
