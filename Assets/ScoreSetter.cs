using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSetter : MonoBehaviour
{
    // Text object to change
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //Display our score on the gameover screen
        scoreText.text += PlayerPrefs.GetInt("score");
    }
}
