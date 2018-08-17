using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour {
    public GameObject camara;
    public Transform destino;

    private void OnTriggerEnter2D (Collider2D other)
    {
        other.transform.position = destino.transform.position;
        camara.transform.position = new Vector3(93.3f, 1, -10);
    }
}
