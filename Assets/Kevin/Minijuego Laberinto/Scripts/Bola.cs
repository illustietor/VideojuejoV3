using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

    bool ponerPausa = true;
    public GameObject menuPausaMj;
    public GameObject menuFinalMj;

    public float velocidad = 5;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(horizontal * velocidad, vertical * velocidad);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && ponerPausa)
        {
            PausaJuego();
        }
    }

    public void PausaJuego()
    {
        Time.timeScale = 0;
        menuPausaMj.SetActive(true);
        Debug.Log("Juego Pausado");

    }

    public void PausaFalse()
    {
        ponerPausa = false;
    }
}
