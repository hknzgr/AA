using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {


    GameObject donenCember, anaCember;
    public Animator animator;
	void Start ()
    {
        donenCember = GameObject.FindGameObjectWithTag("donencembertag");
        anaCember = GameObject.FindGameObjectWithTag("anacembertag");
    }
	
	
	void Update ()
    {
		
	}

    public void gameOver()
    {
        donenCember.GetComponent<dondurmeScript>().enabled = false;
        anaCember.GetComponent<anaCemberScript>().enabled = false;
        animator.SetTrigger("gameOver");
    }
}
