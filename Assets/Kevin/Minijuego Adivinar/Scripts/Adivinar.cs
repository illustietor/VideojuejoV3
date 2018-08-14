using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Adivinar : MonoBehaviour
{

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

    void FinalJuego()
    {
        if (tiempoTotal >= 20f)
        {
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.R))
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
                Time.timeScale = 1;
            }
        }
    }

    void ElegirOpciones()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (imagen.sprite == platano) //Elige la primera opcion (Triangulo)
            {
                puntuacion++;
                AleatorizarImagenes();
                tiempo = 0;
            }
            else
            {
                puntuacion--;
                AleatorizarImagenes();
                tiempo = 0;
            }
        }
        

        if (Input.GetKeyDown(KeyCode.UpArrow)) //Elige la segunda opcion (Circulo)
        {
            if (imagen.sprite == sandia)
            {
                puntuacion++;
                AleatorizarImagenes();
                tiempo = 0;
            }
            else
            {
                puntuacion--;
                AleatorizarImagenes();
                tiempo = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) //Elige la tercera opcion (Cuadrado)
        {
            if (imagen.sprite == manzana)
            {
                puntuacion++;
                AleatorizarImagenes();
                tiempo = 0;
            }
            else
            {
                puntuacion--;
                AleatorizarImagenes();
                tiempo = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) //Elige la cuarta opcion (Mierda Pura)
        {
            if (imagen.sprite == platanoPodrido || imagen.sprite == manzanaPodrida || imagen.sprite == sandiaPodrida || imagen.sprite == lata)
            {
                puntuacion++;
                AleatorizarImagenes();
                tiempo = 0;
            }
            else
            {
                puntuacion--;
                AleatorizarImagenes();
                tiempo = 0;
            }
        }
    }


    void Start()
    {
        //Al inicio del juego se activa una imagen

        imagenes[0] = platano;
        imagenes[1] = sandia;
        imagenes[2] = manzana;
        imagenes[3] = platanoPodrido;
        imagenes[4] = manzanaPodrida;
        imagenes[5] = sandiaPodrida;
        imagenes[6] = lata;
    }

    void Update()
    {
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

        FinalJuego();
    }
}
