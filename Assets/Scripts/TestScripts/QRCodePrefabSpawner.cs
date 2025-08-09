using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Spawns and updates a prefab based on the QR code message.
/// </summary>
public class QRCodePrefabSpawner : MonoBehaviour
{
    [Header("Prefab Mapping")]
    [Tooltip("Assign your prefabs and their QR code keys here.")]
    public List<PrefabEntry> prefabEntries;

    private Dictionary<string, GameObject> prefabMap = new Dictionary<string, GameObject>();
    private Dictionary<string, GameObject> spawnedObjects = new Dictionary<string, GameObject>();

    [System.Serializable]
    public struct PrefabEntry
    {
        public string qrCodeMessage;
        public GameObject prefab;
    }

    void Awake()
    {
        // Build the map for quick lookup
        foreach (var entry in prefabEntries)
        {
            if (!prefabMap.ContainsKey(entry.qrCodeMessage) && entry.prefab != null)
                prefabMap.Add(entry.qrCodeMessage, entry.prefab);
        }
    }

    /// <summary>
    /// Call this when a QR code is detected.
    /// </summary>
    /// <param name="qrCodeMessage">The message from the QR code (e.g., "petri_dish").</param>
    /// <param name="worldPosition">Where to spawn the prefab.</param>
    /// <param name="rotation">Rotation for the prefab.</param>
    public void OnQRCodeDetected(string qrCodeMessage, Vector3 worldPosition, Quaternion rotation)
    {
        if (!prefabMap.ContainsKey(qrCodeMessage))
        {
            Debug.LogWarning($"QRCodePrefabSpawner: No prefab mapped for QR code '{qrCodeMessage}'");
            return;
        }

        GameObject prefab = prefabMap[qrCodeMessage];

        // Spawn or move the prefab for this QR code
        if (!spawnedObjects.ContainsKey(qrCodeMessage) || spawnedObjects[qrCodeMessage] == null)
        {
            GameObject obj = Instantiate(prefab, worldPosition, rotation);
            spawnedObjects[qrCodeMessage] = obj;
            Debug.Log($"QRCodePrefabSpawner: Spawned '{qrCodeMessage}' prefab at {worldPosition}");
        }
        else
        {
            spawnedObjects[qrCodeMessage].transform.SetPositionAndRotation(worldPosition, rotation);
            Debug.Log($"QRCodePrefabSpawner: Moved '{qrCodeMessage}' prefab to {worldPosition}");
        }
    }

    /// <summary>
    /// Optionally remove a spawned prefab if the QR code is lost.
    /// </summary>
    public void RemoveSpawnedObject(string qrCodeMessage)
    {
        if (spawnedObjects.ContainsKey(qrCodeMessage) && spawnedObjects[qrCodeMessage] != null)
        {
            Destroy(spawnedObjects[qrCodeMessage]);
            spawnedObjects[qrCodeMessage] = null;
            Debug.Log($"QRCodePrefabSpawner: Removed '{qrCodeMessage}' prefab.");
        }
    }
}
