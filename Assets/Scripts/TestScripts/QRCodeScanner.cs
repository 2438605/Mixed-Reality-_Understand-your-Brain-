//using UnityEngine;
//using ZXing;
//using ZXing.QrCode;

//public class QRCodeScanner : MonoBehaviour
//{
//    [Header("Dependencies")]
//    public PassthroughCameraFeed cameraFeed; // Assign in inspector
//    public QRCodePrefabSpawner prefabSpawner; // Assign in inspector
//    public Camera mainCamera; // Assign the Quest main camera

//    [Header("Scan Settings")]
//    public float scanInterval = 0.2f; // Seconds between scans

//    private BarcodeReader barcodeReader; // Use ZXing.Unity.BarcodeReader
//    private float lastScanTime = 0f;
//    private string lastResultText = "";

//    void Start()
//    {
//        if (cameraFeed == null)
//        {
//            Debug.LogError("QRCodeScanner: PassthroughCameraFeed not assigned!");
//            enabled = false;
//            return;
//        }

//        // Use Unity binding for ZXing
//        barcodeReader = new BarcodeReader();
//        Debug.Log("QRCodeScanner: Initialized ZXing.Unity BarcodeReader.");
//    }

//    void Update()
//    {
//        if (!cameraFeed.IsReady)
//            return;

//        if (Time.time - lastScanTime < scanInterval)
//            return;

//        lastScanTime = Time.time;

//        try
//        {
//            Color32[] pixels = cameraFeed.GetFramePixels();
//            int width = cameraFeed.camTexture.width;
//            int height = cameraFeed.camTexture.height;

//            if (pixels == null || width <= 16 || height <= 16)
//            {
//                Debug.LogWarning("QRCodeScanner: Camera feed not ready.");
//                return;
//            }

//            // ZXing expects bottom-left origin; Unity's WebCamTexture is usually correct
//            var result = barcodeReader.Decode(pixels, width, height);

//            if (result != null)
//            {
//                if (result.Text != lastResultText)
//                {
//                    Debug.Log($"QRCodeScanner: QR Code detected: {result.Text}");

//                    // Approximate center of the QR code (ZXing does not give corners)
//                    Vector2 qrScreenPos = new Vector2(width / 2, height / 2);

//                    // Project to world space (approximate, assumes QR code is in center of frame)
//                    Vector3 worldPos = mainCamera.ScreenToWorldPoint(
//                        new Vector3(qrScreenPos.x * ((float)Screen.width / width),
//                                    qrScreenPos.y * ((float)Screen.height / height),
//                                    2.0f)); // 2m in front (adjust as needed)

//                    prefabSpawner.OnQRCodeDetected(result.Text, worldPos, Quaternion.identity);

//                    lastResultText = result.Text;
//                }
//            }
//            else
//            {
//                // Optionally, handle loss of QR code here
//            }
//        }
//        catch (System.Exception ex)
//        {
//            Debug.LogError($"QRCodeScanner: Exception during decode: {ex.Message}");
//        }
//    }
//}
