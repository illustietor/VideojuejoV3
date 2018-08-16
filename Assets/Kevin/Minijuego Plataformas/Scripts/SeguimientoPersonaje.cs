using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoPersonaje : MonoBehaviour {

    public Transform personaje;

    Vector3 velocidad = Vector3.zero;

    public float smoothTime = 0.15f;

    private void FixedUpdate()
    {
        Vector3 posPersonaje = personaje.position;

        posPersonaje.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, personaje.position, ref velocidad, smoothTime);
    }
}
