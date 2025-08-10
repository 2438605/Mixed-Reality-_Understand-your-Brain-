using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    // Array of buttons
    public Button[] buttons;
    // Corresponding labels (e.g., Text or GameObjects to show/hide)
    public GameObject[] labels;

    // Index of the currently active button (-1 means none)
    private int activeIndex = -1;

    void Start()
    {
        // Add listeners to buttons
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i;  // Capture index for the closure
            buttons[i].onClick.AddListener(() => OnButtonPressed(index));
        }

        // Initially hide all labels
        foreach (var label in labels)
            label.SetActive(false);
    }

    void OnButtonPressed(int index)
    {
        // If the clicked button is already active, toggle off
        if (activeIndex == index)
        {
            labels[index].SetActive(false);
            activeIndex = -1;
            return;
        }

        // Hide previously active label
        if (activeIndex != -1)
        {
            labels[activeIndex].SetActive(false);
        }

        // Show the label for the newly clicked button
        labels[index].SetActive(true);
        activeIndex = index;
    }
}
