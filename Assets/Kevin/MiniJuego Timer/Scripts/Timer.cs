using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Image fondo;
    public Sprite preparados, go, playerMuerto, botMuerto;
    public GameObject menuPausaMj;
    public GameObject menuFinalMj;
    bool ponerPausa = true;


    bool Go;
    public float tiempo;

	void Start () {
        Time.timeScale = 1;
        Temporizador();
    }
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.P) && ponerPausa)
        {
            PausaJuego();
        }

        Pulsar();

        if (Go)
        {
            tiempo += Time.deltaTime;
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

    void Temporizador ()
    {
        StartCoroutine(PreparadosListosYa());
    }

    public IEnumerator PreparadosListosYa()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("READY: " + Time.time);
        yield return new WaitForSeconds(2f);
        Debug.Log("STEADY: " + Time.time);
        yield return new WaitForSeconds(Random.Range(1f, 5f));
        Debug.Log("GO");
        fondo.sprite = go;
        Go = true;
        
    }

    public IEnumerator EsperarFinal()
    {
        yield return new WaitForSeconds(1f);
        FinJuego();
    }

    void Pulsar()
    {
        if (!Go && Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space) && tiempo >= 0.4f)
        {
            Debug.Log("Has perdido");
            fondo.sprite = playerMuerto;
            StartCoroutine(EsperarFinal());
            //Time.timeScale = 0;
        }

        else if (Go && Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space) && tiempo <= 0.4f)
        {
            Debug.Log("Has ganado");
            fondo.sprite = botMuerto;
            StartCoroutine(EsperarFinal());
            //Time.timeScale = 0;
        }
    }
}
