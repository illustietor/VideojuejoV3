using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubitos : MonoBehaviour {
    public float speed = 10f;

    public GameObject player;
    public GameObject objetivo;

    bool ponerPausa = true;
    public GameObject menuPausaMj;
    public GameObject menuFinalMj;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && ponerPausa)
        {
            PausaJuego();
        }

        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);
    }

    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<MeshRenderer>().material.color = new Color(0f, 255f, 0f);
        objetivo.GetComponent<MeshRenderer>().material.color = new Color(0f, 255f, 0f);

        StartCoroutine(Esperar());
        //StopCoroutine(Esperar());
    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(0.5f);
        FinJuego();
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
