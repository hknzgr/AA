using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class anaCemberScript : MonoBehaviour {

    public GameObject kucukCember;
    public Text anaCemberText;
    public Text altCemberText;
    public Text altCemberText2;
    public int anaCemberAdedi = 0;

    void Start ()
    {
        anaCemberText.GetComponent<Text>();
        altCemberText.GetComponent<Text>();
        altCemberText2.GetComponent<Text>();
        anaCemberText.text = anaCemberAdedi + "";
        altCemberText.text = anaCemberAdedi - 1 + "";
        altCemberText2.text = anaCemberAdedi - 2 + "";
    }
	
	
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            kucukCemberOlustur();
            anaCemberAdedi--;
            anaCemberText.text = anaCemberAdedi + "";
            altCemberText.text = anaCemberAdedi -1 +"";
            altCemberText2.text = anaCemberAdedi -2 +"";
            
        }
    }

    void kucukCemberOlustur()
    {
        Instantiate(kucukCember, transform.position, transform.rotation);
    }
}
