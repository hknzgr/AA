﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukCemberScript : MonoBehaviour {

    Rigidbody2D fizik;
    public float hiz;
    bool hareketKontrol = false;
    GameObject gameController;
	void Start ()
    {
        fizik = GetComponent<Rigidbody2D>();
        gameController = GameObject.FindGameObjectWithTag("gamecontroller");
    }
	
	
	void FixedUpdate ()
    {
        if (!hareketKontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
       
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag=="donencembertag")
        {
            transform.SetParent(col.transform);
            hareketKontrol = true;
        }
        if (col.tag=="kucukcembertag")
        {
            gameController.GetComponent<gameController>().gameOver();
        }
    }
}
