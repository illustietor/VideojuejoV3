using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mini_Moverse : MonoBehaviour {
    public Rigidbody miRigidBody;
    bool ponerPausa = true;
    public GameObject menuPausaMj;
    public GameObject menuFinalMj;

    void Start ()
    {
        Time.timeScale = 1;
    }
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.P) && ponerPausa)
        {
            PausaJuego();
        }

        float horizontal = Input.GetAxisRaw("Horizontal");

        Vector2 direccion = new Vector2(horizontal, 0);

        direccion.Normalize();
        direccion.x *= 10;
        direccion.y = 0;
        miRigidBody.velocity = direccion;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Zanahoria"))
        {
            FinJuego();
            //Time.timeScale = 0;
            //Debug.Log("Has perdido");
        }
    }

    public void PausaJuego()
    {
        Time.timeScale = 0;
        menuPausaMj.SetActive(true);
        Debug.Log("Juego Pausado");

    }

    public void FinJuego()
    {
        ponerPausa = false;
        Time.timeScale = 0;
        menuFinalMj.SetActive(true);
        Debug.Log("Juego Finalizado");

    }
}
