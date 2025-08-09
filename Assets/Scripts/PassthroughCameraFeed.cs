using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PassthroughCameraFeed : MonoBehaviour
{
    [Header("Camera Settings")]
    public string cameraDeviceName = ""; // Leave empty for default device
    public int requestedWidth = 1280;
    public int requestedHeight = 720;
    public int requestedFPS = 30;

    [Header("Optional Debug UI")]
    public RawImage debugRawImage; // Assign in inspector to see the feed

    [HideInInspector]
    public WebCamTexture camTexture;

    public bool IsReady => camTexture != null && camTexture.isPlaying && camTexture.width > 16;

    void Start()
    {
        StartCoroutine(InitializeCamera());
    }

    IEnumerator InitializeCamera()
    {
        // Wait for camera permission
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);
        if (!Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            Debug.LogError("WebCam permission not granted!");
            yield break;
        }

        // Find the correct camera device (if not specified, use default)
        WebCamDevice[] devices = WebCamTexture.devices;
        string deviceToUse = cameraDeviceName;
        if (string.IsNullOrEmpty(deviceToUse) && devices.Length > 0)
            deviceToUse = devices[0].name;

        camTexture = new WebCamTexture(deviceToUse, requestedWidth, requestedHeight, requestedFPS);
        camTexture.Play();

        // Optionally show on UI
        if (debugRawImage != null)
            debugRawImage.texture = camTexture;

        // Wait until camera is initialized
        float timer = 0f;
        while (camTexture.width <= 16 && timer < 5f)
        {
            yield return null;
            timer += Time.deltaTime;
        }

        if (camTexture.width <= 16)
            Debug.LogWarning("Camera initialization timeout or failed.");
        else
            Debug.Log($"Camera started: {camTexture.deviceName} ({camTexture.width}x{camTexture.height})");
    }

    public Color32[] GetFramePixels()
    {
        if (IsReady)
            return camTexture.GetPixels32();
        else
            return null;
    }

    void OnDestroy()
    {
        if (camTexture != null)
            camTexture.Stop();
    }
}
