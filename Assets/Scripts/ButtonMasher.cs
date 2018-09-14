using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    public AudioSource clickSound; //sound that will play when we click the button


	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");	
	}//
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Start method updated");
	}//End of Update

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");
        // Trigger our clicking sound to play
        clickSound.Play();
    }// End of OnMouseDown

}//End of Button Masher Class
