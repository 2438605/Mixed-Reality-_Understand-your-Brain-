using UnityEngine;

public class InnerVoiceController : MonoBehaviour
{
    public AudioSource innerVoiceAudio; // Assign the Audio Source in Inspector

    public void PlayInnerVoice()
    {
        if (!innerVoiceAudio.isPlaying)
        {
            innerVoiceAudio.Play();
        }
    }
}
