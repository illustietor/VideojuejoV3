using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Adivinar : MonoBehaviour
{
    bool ponerPausa = true;
    public GameObject menuPausaMj;
    public GameObject menuFinalMj;

    public GameObject error;
    public GameObject acierto;
    public Image imagen;
    public Sprite sandia, manzana, sandiaPodrida, manzanaPodrida, platanoPodrido, platano, lata;
    Sprite[] imagenes = new Sprite[7];

    float tiempo;
    public float tiempoTotal;

    public int puntuacion;

    void AleatorizarImagenes()
    {
        imagen.sprite = imagenes[Random.Range(0, imagenes.Length)];
    }

    //void FinalJuego()
    //{
    //    if (tiempoTotal >= 40f)
    //    {
    //        Time.timeScale = 0;
    //        if (Input.GetKeyDown(KeyCode.R))
    //        {
    //            Scene scene = SceneManager.GetActiveScene();
    //            SceneManager.LoadScene(scene.name);
    //            Time.timeScale = 1;
    //        }
    //    }
    //}

    void ElegirOpciones()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (imagen.sprite == platano)
            {
                puntuacion++;
                acierto.SetActive(true);
                StartCoroutine(EsperarAcierto());
                StopCoroutine(EsperarAcierto());
            }
            else
            {
                puntuacion--;
                error.SetActive(true);
                StartCoroutine(EsperarError());
                StopCoroutine(EsperarError());
            }
        }
        

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (imagen.sprite == sandia)
            {
                puntuacion++;
                acierto.SetActive(true);
                StartCoroutine(EsperarAcierto());
                StopCoroutine(EsperarAcierto());
            }
            else
            {
                puntuacion--;
                error.SetActive(true);
                StartCoroutine(EsperarError());
                StopCoroutine(EsperarError());
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (imagen.sprite == manzana)
            {
                puntuacion++;
                acierto.SetActive(true);
                StartCoroutine(EsperarAcierto());
                StopCoroutine(EsperarAcierto());
            }
            else
            {
                puntuacion--;
                error.SetActive(true);
                StartCoroutine(EsperarError());
                StopCoroutine(EsperarError());
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (imagen.sprite == platanoPodrido || imagen.sprite == manzanaPodrida || imagen.sprite == sandiaPodrida || imagen.sprite == lata)
            {
                puntuacion++;
                acierto.SetActive(true);
                StartCoroutine(EsperarAcierto());
                StopCoroutine(EsperarAcierto());
            }
            else
            {
                puntuacion--;
                error.SetActive(true);
                StartCoroutine(EsperarError());
                StopCoroutine(EsperarError());
            }
        }
    }


    void Start()
    {
        Time.timeScale = 1;

        //Al inicio del juego se activa una imagen

        imagenes[0] = platano;
        imagenes[1] = sandia;
        imagenes[2] = manzana;
        imagenes[3] = platanoPodrido;
        imagenes[4] = manzanaPodrida;
        imagenes[5] = sandiaPodrida;
        imagenes[6] = lata;

        error.SetActive(false);
        acierto.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && ponerPausa)
        {
            PausaJuego();
        }

        tiempo += Time.deltaTime;
        tiempoTotal += Time.deltaTime;

        if (tiempo >= 3f)
        {
            AleatorizarImagenes();

            tiempo = 0;
        }
        if (Time.timeScale == 1)
        {
            ElegirOpciones();
        }

        //FinalJuego();

        if (tiempoTotal >= 40f)
        {
            FinJuego();
        }

    }

    IEnumerator EsperarError()
    {
        yield return new WaitForSeconds(0.5f);
        error.SetActive(false);
        AleatorizarImagenes();
        tiempo = 0;
    }

    IEnumerator EsperarAcierto()
    {
        yield return new WaitForSeconds(0.5f);
        acierto.SetActive(false);
        AleatorizarImagenes();
        tiempo = 0;
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
