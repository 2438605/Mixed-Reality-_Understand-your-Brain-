using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button[] buttons;   // Assign 6 buttons in the Inspector
    public int correctIndex;   // Set this in Inspector to choose the correct button manually

    void Start()
    {
        // Assign click events to each button
        foreach (Button btn in buttons)
        {
            btn.onClick.AddListener(() => CheckAnswer(btn));
        }
    }

    void CheckAnswer(Button clickedButton)
    {
        if (clickedButton == buttons[correctIndex])
        {
            clickedButton.image.color = Color.green; // Correct choice
            Debug.Log("Correct choice!");
        }
        else
        {
            clickedButton.image.color = Color.red; // Wrong choice
            Debug.Log("Wrong choice, try again!");
        }
    }
}
