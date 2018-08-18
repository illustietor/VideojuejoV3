using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class RitaCoversacion1 : MonoBehaviour {
    public Flowchart rita1;

    private void OnTriggerEnter (Collider other)
    {
        rita1.gameObject.SetActive(true);
    }
}
