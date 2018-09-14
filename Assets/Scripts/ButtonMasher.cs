using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    public AudioSource clickSound; //sound that will play when we click the button
    public TextMesh scoreText; // display text for the player's score
    public TextMesh timerText; // display text for the player's timer remaining
    public float gameLength; //How many seconds will the game last
    public AudioSource gameOverSound; //sound that will play when we run out of time
    public TextMesh messageText; //Displays a message when the game ends

    private int score = 0; // the numerical data value of our score
    private float timeRemaining = 0; //Numerical time remaining
    private bool gameRunning = false;

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");

	}// End of start
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Start method updated");

        timeRemaining = timeRemaining - Time.deltaTime;

        timerText.text = (Mathf.CeilToInt(timeRemaining)).ToString();

        //Check if we have run out of time
        if (timeRemaining <= 0)
        {

            //Only do this if we just now hit game over
            if (gameRunning == true)
            {
                //play the game over sound
                gameOverSound.Play();

                messageText.text = "Time up! Score = " + score.ToString();
            }
            //stop the game running
            gameRunning = false;

            timeRemaining = 0;
        }// End of if statement
	}//End of Update

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");

        if (gameRunning == true)
        {
            // Trigger our clicking sound to play
            clickSound.Play();
            // Increase the score by 1
            score = score + 1;
            // update visual score
            scoreText.text = score.ToString();
        }// End of if (gameRunning == true)

        else
        {
            //Game is not running when we click the buttong
            gameRunning = true;

            timeRemaining = gameLength;

            // tells the player how to play
            messageText.text = "Mash the button!";

            //Reset the score
            score = 0;


        }

    }// End of OnMouseDown

}//End of Button Masher Class
