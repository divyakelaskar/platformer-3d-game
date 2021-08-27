using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private float playerScore = 0f;
    public Text scoreText;

    public float scoreTime = 1f;


    void Awake()
    {
        // Set up the reference.
        scoreText = GetComponent<Text>();

        // Reset the score.
        playerScore = 0;
    }


    // Update is called once per frame
    void Update()
    {

        
            playerScore = Time.time + scoreTime;
            int fScore = (int)playerScore;
            scoreText.text = "Score : " + fScore;
        

    }



}
