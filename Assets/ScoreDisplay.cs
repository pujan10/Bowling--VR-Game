using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public PinManager pinManager; // Reference to PinManager
    public Text scoreText; // Reference to UI Text

    void Update()
    {
        // Update the score text with the number of pins knocked down
        int score = pinManager.GetFallenPinCount();
        scoreText.text = "Score: " + score.ToString();
    }
}
