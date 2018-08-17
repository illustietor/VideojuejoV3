using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuarJuego : MonoBehaviour {

    public GameObject menuPausaMj;

    public void QuitarPausa()
    {
        menuPausaMj.SetActive(false);
        Time.timeScale = 1;

    }
}
