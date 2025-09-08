using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VRVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button startButton;
    public Button stopButton;

    void Start()
    {
        // Attach button listeners
        startButton.onClick.AddListener(PlayVideo);
        stopButton.onClick.AddListener(StopVideo);
    }

    public void PlayVideo()
    {
        if (videoPlayer != null && !videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
    }

    public void StopVideo()
    {
        if (videoPlayer != null && videoPlayer.isPlaying)
        {
            videoPlayer.Stop();
        }
    }
}
