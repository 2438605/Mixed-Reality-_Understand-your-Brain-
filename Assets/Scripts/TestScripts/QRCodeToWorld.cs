using UnityEngine;

/// <summary>
/// Converts a 2D QR code screen/camera position to a 3D world position in front of the camera.
/// For best results, calibrate the depth or use Quest's spatial mapping if available.
/// </summary>
public class QRCodeToWorld : MonoBehaviour
{
    [Header("Camera Reference")]
    public Camera mainCamera; // Assign the Quest's main camera in the Inspector

    [Header("Projection Settings")]
    [Tooltip("Estimated distance from camera to QR code in meters.")]
    public float projectionDepth = 2.0f; // Adjust as needed for your environment

    /// <summary>
    /// Converts a 2D point in camera image space to a 3D world point.
    /// </summary>
    /// <param name="qrCodeScreenPos">QR code position in pixel coordinates (e.g., from ZXing result)</param>
    /// <param name="cameraTextureWidth">Width of the camera texture</param>
    /// <param name="cameraTextureHeight">Height of the camera texture</param>
    /// <returns>3D world position</returns>
    public Vector3 GetWorldPosition(Vector2 qrCodeScreenPos, int cameraTextureWidth, int cameraTextureHeight)
    {
        if (mainCamera == null)
        {
            Debug.LogError("QRCodeToWorld: mainCamera not assigned!");
            return Vector3.zero;
        }

        // Convert camera pixel coordinates to Unity screen coordinates
        // Unity's (0,0) is bottom-left, camera texture may be different, so flip Y if needed
        float screenX = qrCodeScreenPos.x * ((float)Screen.width / cameraTextureWidth);
        float screenY = qrCodeScreenPos.y * ((float)Screen.height / cameraTextureHeight);

        Vector3 screenPoint = new Vector3(screenX, screenY, projectionDepth);

        // Project to world space
        Vector3 worldPos = mainCamera.ScreenToWorldPoint(screenPoint);

        Debug.Log($"QRCodeToWorld: QR at screen ({screenX}, {screenY}) projects to world {worldPos}");

        return worldPos;
    }
}
