using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorZanahorias : MonoBehaviour {
    public GameObject objetoACrear;

    float tiempo;

    void Start () {

    }

	void Update () {
        tiempo += Time.deltaTime;

        if (tiempo >= 1)
        {
            Instantiate(objetoACrear, new Vector3(Random.Range(-10f,10f), 8f, -0.5f), Quaternion.identity);
            tiempo = 0;
        }
	}
}
