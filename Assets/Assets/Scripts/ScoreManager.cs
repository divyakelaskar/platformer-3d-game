using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;        // The player's score.


    Text text;                      // Reference to the Text component.


    void Start() {
        score = 0;
    }

    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        score = 0;
    }


    void Update()
    {
        
        text.text = "Score: " + score;          //Updates the scpre value
    }
}
