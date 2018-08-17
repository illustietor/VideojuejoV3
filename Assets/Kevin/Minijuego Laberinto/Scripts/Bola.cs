using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {
    public float velocidad = 5;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(horizontal * velocidad, vertical * velocidad);
    }
}
