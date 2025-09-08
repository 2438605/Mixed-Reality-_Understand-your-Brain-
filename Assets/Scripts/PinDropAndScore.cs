using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PinGameManager : MonoBehaviour
{
    [Header("Game Settings")]
    public int totalPins = 4; // total number of pins in the game
    public int passingScore = 3; // minimum score to pass

    [Header("UI Elements")]
    public TMP_Text scoreText;
    public TMP_Text resultText;

    [Header("This BoxCollider's Correct Tag")]
    public string correctTag; // Assign per box in Inspector

    private static int totalScore = 0; // Total score across all boxes
    private static int pinsPlaced = 0; // How many pins have been placed

    private void Start()
    {
        // Initialize UI
        if (scoreText != null) scoreText.text = "Score: 0";
        if (resultText != null) resultText.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        // Only check if this pin matches this box's correct tag
        if (other.CompareTag(correctTag))
        {
            Debug.Log("Correct pin placed: " + other.name);

            totalScore += 10;
            pinsPlaced += 10;

            if (scoreText != null)
                scoreText.text = "Score: " + totalScore;

            // Optional: snap the pin to the box
            // other.transform.position = transform.position;

            CheckEndGame();
        }
        else
        {
            Debug.Log("Wrong pin placed: " + other.name);
        }
    }

    private void CheckEndGame()
    {
        // Check if all pins have been placed
        if (pinsPlaced >= totalPins)
        {
            if (resultText != null)
            {
                if (totalScore >= passingScore)
                    resultText.text = "You Passed! Final Score: " + totalScore;
                else
                    resultText.text = "You Failed. Final Score: " + totalScore;
            }

            Debug.Log("Game Over! Final Score: " + totalScore);
        }
    }
}
