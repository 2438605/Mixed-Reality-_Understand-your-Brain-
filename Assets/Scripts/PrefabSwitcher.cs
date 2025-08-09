using UnityEngine;

public class PrefabSwitcher : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public Transform spawnPoint;

    private GameObject currentPrefab;

    void Start()
    {
        // Spawn the first prefab at start
        currentPrefab = Instantiate(prefab1, spawnPoint.position, spawnPoint.rotation);
    }

    public void SwitchPrefab()
    {
        // Destroy the current prefab
        if (currentPrefab != null)
        {
            Destroy(currentPrefab);
        }

        // Choose which prefab to spawn
        currentPrefab = Instantiate(
            currentPrefab == prefab1 ? prefab2 : prefab1,
            spawnPoint.position,
            spawnPoint.rotation
        );
    }
}
