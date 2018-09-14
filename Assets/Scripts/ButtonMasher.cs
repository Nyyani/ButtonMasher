using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    public AudioSource clickSound; //sound that will play when we click the button
    public TextMesh scoreText; // display text for the player's score
    public TextMesh timerText; // display text for the player's timer remaining
    public float gameLength; //How many seconds will the game last

    private int score = 0; // the numerical data value of our score
    private float timeRemaining = 0; //Numerical time remaining

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");

        timeRemaining = gameLength;

	}// End of start
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Start method updated");

        timeRemaining = timeRemaining - Time.deltaTime;

        timerText.text = (Mathf.CeilToInt(timeRemaining)).ToString(); 

	}//End of Update

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");
        // Trigger our clicking sound to play
        clickSound.Play();
        // Increase the score by 1
        score = score + 1;
        // update visual score
        scoreText.text = score.ToString();
    }// End of OnMouseDown

}//End of Button Masher Class
