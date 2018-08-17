using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour {

    public GameObject camara2;
    public Transform destino;

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = destino.transform.position;
        camara2.transform.position = new Vector3(178.8f, 1, -10);
    }
}
