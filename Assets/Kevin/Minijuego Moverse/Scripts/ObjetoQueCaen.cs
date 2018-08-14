using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoQueCaen : MonoBehaviour {
    Zanahoria creadorZanahoria;

    float tiempo;

    void Start () {

    }

	void Update () {
        tiempo += Time.deltaTime;

        if (tiempo >= 1)
        {
            creadorZanahoria.Instacia();
            tiempo = 0;
        }
	}
}
