using UnityEngine;
using System.Collections;

public class StartPointAudioTrigger : MonoBehaviour
{
    public AudioSource innerVoiceAudio; // Drag the InnerVoice Audio Source here
    public float delayBeforePlay = 5f; // Delay before audio starts
    private bool hasTriggered = false; // Prevent multiple triggers

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered) // Make sure the Player has the right tag
        {
            hasTriggered = true; // Prevent multiple triggers
            Debug.Log("Player entered the start point. Waiting to play audio...");
            StartCoroutine(PlayAudioAfterDelay());
        }
    }

    private IEnumerator PlayAudioAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforePlay); // Wait for delay
        if (innerVoiceAudio != null)
        {
            innerVoiceAudio.Play();
            Debug.Log("Inner voice audio started.");
        }
        else
        {
            Debug.LogError("Error: Inner Voice Audio Source is not assigned!");
        }
    }
}
