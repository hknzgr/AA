using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startTheGame()
    {
        SceneManager.LoadScene("level1");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
