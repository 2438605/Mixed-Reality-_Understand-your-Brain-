using UnityEngine;
using UnityEngine.UI;

public class ButtonColorChanger : MonoBehaviour
{
    private Image buttonImage;

    void Start()
    {
        buttonImage = GetComponent<Image>(); // Get the Image component on this button
    }

    public void ChangeToGreen()
    {
        buttonImage.color = Color.green; // Change the image color to green
    }
}
