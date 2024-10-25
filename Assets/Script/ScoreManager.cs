using UnityEngine;
using TMPro;  // Import the TextMeshPro namespace

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;   // Reference to the TMP Text element
    public int score = 0;               // The player's score

    void Start()
    {
        UpdateScoreText();
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object that passed through the net is the ball
        if (other.CompareTag("Ball"))
        {
            // Increase the score
            score=score+2;
            UpdateScoreText();
        }
    }

    // Update the TMP text with the current score
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
