using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ButtonPressController : MonoBehaviour
{
    public GameObject uiPanelToShow; // Assign the UI Panel that should appear
    public Button newButtonOnTable;  // Assign the new button on the table

    void Start()
    {
        // Initially hide the UI Panel
        uiPanelToShow.SetActive(true);

        // Add listener for the new button press
        newButtonOnTable.onClick.AddListener(OnNewButtonPressed);
    }

    // This method is called when the new button is pressed
    public void OnNewButtonPressed()
    {
        // Show the UI Panel when the button is pressed
        uiPanelToShow.SetActive(true);
    }

}
