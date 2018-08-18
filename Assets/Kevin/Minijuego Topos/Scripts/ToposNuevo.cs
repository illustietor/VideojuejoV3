﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToposNuevo : MonoBehaviour {

    bool ponerPausa = true;
    public GameObject menuPausaMj;
    public GameObject menuFinalMj;

    public enum Topos
    {
        topoArriba,
        topoAbajo,
        topoDerecha,
        topoIzquierda
    }

    public Image[] topo;
    public Sprite topoFuera, topoGolpeado, topoEscondido;

    public int puntuacion;
    public int puntuaciónParaGanar = 20;

    public float tiempoMinimoAparecer, tiempoMaximoAparecer;
    public float tiempoMinimoDesaparecer , tiempoMaximoDesaparecer;
    public float tiempoMaximoGolpeado;
    public float tiempoTotal;
    public float tiempoDeJuego = 30F;

    float[] tiempoRandomAparecer;
    float[] tiempoRandomDesaparecer;
    float[] tiempoActual;

	// Use this for initialization
	void Start () {

        Time.timeScale = 1;
        //coroutineTopoArriba = StartCoroutine(AparecerYDesaparecerTopo(topoArriba));
        //coroutineTopoAbajo = StartCoroutine(AparecerYDesaparecerTopo(topoAbajo));
        //coroutineTopoDerecha = StartCoroutine(AparecerYDesaparecerTopo(topoDerecha));
        //coroutineTopoIzquierda = StartCoroutine(AparecerYDesaparecerTopo(topoIzquierda));
        tiempoRandomAparecer = new float[4];
        tiempoRandomDesaparecer = new float[4];
        tiempoActual = new float[4];
        for (int i = 0; i < tiempoRandomAparecer.Length; i++)
        {
            CambiarTiempoRandomTopo(i);
        }
    }

    void FinalJuego()
    {
        if (tiempoTotal > tiempoDeJuego && puntuacion < puntuaciónParaGanar)
        {
            ponerPausa = false;
            Time.timeScale = 0;
            topo[0].sprite = topoEscondido;
            topo[1].sprite = topoEscondido;
            topo[2].sprite = topoEscondido;
            topo[3].sprite = topoEscondido;
            menuFinalMj.SetActive(true);
        }

        if (tiempoTotal < tiempoDeJuego && puntuacion >= puntuaciónParaGanar)
        {
            ponerPausa = false;
            Time.timeScale = 0;
            topo[0].sprite = topoGolpeado;
            topo[1].sprite = topoGolpeado;
            topo[2].sprite = topoGolpeado;
            topo[3].sprite = topoGolpeado;
            menuFinalMj.SetActive(true);
        }
    }


    private void CambiarTiempoRandomTopo(int topo){
        tiempoRandomAparecer[topo] = Random.Range(tiempoMinimoAparecer, tiempoMaximoAparecer);
        tiempoRandomDesaparecer[topo] = Random.Range(tiempoMinimoDesaparecer, tiempoMaximoDesaparecer);

    }
	
	// Update is called once per frame
	void Update () {
        tiempoTotal += Time.deltaTime;
        Debug.Log(tiempoTotal);

        if (Input.GetKeyDown(KeyCode.P) && ponerPausa)
        {
            PausaJuego();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && topo[(int)Topos.topoArriba].sprite == topoFuera)
        {
            Debug.Log("He golpeado al topo de arriba");
            topo[0].sprite = topoGolpeado;
            tiempoActual[0] = 0f;
            CambiarTiempoRandomTopo(0);
            puntuacion++;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && topo[(int)Topos.topoAbajo].sprite == topoFuera)
        {
            Debug.Log("He golpeado al topo de abajo");
            topo[1].sprite = topoGolpeado;
            tiempoActual[1] = 0f;
            CambiarTiempoRandomTopo(1);
            puntuacion++;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && topo[(int)Topos.topoDerecha].sprite == topoFuera)
        {
            Debug.Log("He golpeado al topo de derecha");
            topo[2].sprite = topoGolpeado;
            tiempoActual[2] = 0f;
            CambiarTiempoRandomTopo(2);
            puntuacion++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && topo[(int)Topos.topoIzquierda].sprite == topoFuera)
        {
            Debug.Log("He golpeado al topo de izquierda");
            topo[3].sprite = topoGolpeado;
            tiempoActual[3] = 0f;
            CambiarTiempoRandomTopo(3);
            puntuacion++;
        }

        for (int i = 0; i < tiempoActual.Length; i++)
        {
            tiempoActual[i] += Time.deltaTime;
            if (topo[i].sprite == topoEscondido && tiempoActual[i] > tiempoRandomAparecer[i])
            {
                topo[i].sprite = topoFuera;
                tiempoActual[i] = 0;
            }
            else if (topo[i].sprite == topoFuera && tiempoActual[i] > tiempoRandomDesaparecer[i])
            {
                topo[i].sprite = topoEscondido;
                tiempoActual[i] = 0;
            }
            else if (topo[i].sprite == topoGolpeado && tiempoActual[i] > tiempoMaximoGolpeado)
            {
                topo[i].sprite = topoEscondido;
                tiempoActual[i] = 0;
            }
        }

        FinalJuego();
    }

    public void PausaJuego()
    {
        Time.timeScale = 0;
        menuPausaMj.SetActive(true);
        Debug.Log("Juego Pausado");

    }
}
