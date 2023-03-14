using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NetCatching : MonoBehaviour
{
    // Integer to hold the score
    private int score;

    // Text object to change
    public TMP_Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        //Set our default score
        score = 0;

        //Reset our global score
        PlayerPrefs.SetInt("score", score);

        //Set our default text
        ChangeScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void IncreaseScore()
    {
        //Increase our score
        score++;

        //Save our score
        PlayerPrefs.SetInt("score", score);
    }

    // Call when an object enters the trigger zone of the net
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    // Call when an object exits the trigger zone of the net
    private void OnTriggerExit2D(Collider2D collision)
    {
        //When it exits, thats when we know we caught it
        if(collision.tag == "Fish")
        {
            //Caught a fish

            //Increase our score
            IncreaseScore();

            //Change our text
            ChangeScore();

            //Kill the fish
            Destroy(collision.gameObject);
        }

        //If its a bomb, game is over!
        if(collision.tag == "Bomb")
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
