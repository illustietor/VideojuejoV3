using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Image fondo;
    public Sprite preparados, go, playerMuerto, botMuerto;

    bool Go;
    public float tiempo;

	void Start () {
        Temporizador();
    }
	
	void Update () {
        Pulsar();
        if (Go)
        {
            tiempo += Time.deltaTime;
        }
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

    void Pulsar()
    {
        if (!Go && Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space) && tiempo >= 0.4f)
        {
            Debug.Log("Has perdido");
            fondo.sprite = playerMuerto;
            Time.timeScale = 0;
        }

        else if (Go && Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space) && tiempo <= 0.4f)
        {
            Debug.Log("Has ganado");
            fondo.sprite = botMuerto;
            Time.timeScale = 0;
        }
    }
}
