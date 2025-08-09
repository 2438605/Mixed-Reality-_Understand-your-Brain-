using System.Collections;
using UnityEngine;
public class CentreObjectToSpawnPoint: MonoBehaviour
{
    private Transform spawnOrigin;

    void Start()
    {
        spawnOrigin = GameObject.Find("OTHER").transform;

        if (transform.position != spawnOrigin.position)
        {
            transform.position = spawnOrigin.position;
        }
    }
}
