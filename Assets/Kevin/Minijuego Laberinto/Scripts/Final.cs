using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour {
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<Bola>().enabled = false;
        //Time.timeScale = 0;
        player.GetComponent<Bola>().PausaFalse();
        Time.timeScale = 0;
        player.GetComponent<Bola>().menuFinalMj.SetActive(true);
    }
}
