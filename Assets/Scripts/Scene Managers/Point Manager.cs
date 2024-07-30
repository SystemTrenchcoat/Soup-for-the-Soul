using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public int score = 0; // Current score
    public Text scoreText; // UI Text to display the score

    void Start()
    {
        UpdateScoreText();
    }

    // Call this method to add points
    public void AddPoints(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // Call this method to subtract points (if needed)
    public void SubtractPoints(int points)
    {
        score -= points;
        UpdateScoreText();
    }

    // Update the score text UI
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}