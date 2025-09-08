using System.Collections;
using UnityEngine;
public class SpawnObjectManager: MonoBehaviour
{
    private Transform spawnOrigin;

    public YarnCommands yarnCommands; // Reference to the YarnCommands script

    public GameObject[] uiButtonsForBrain;

    public GameObject playerGameObject;

    public float turnSpeed = 10f;

    void Start()
    {
        spawnOrigin = GameObject.Find("OTHER").transform;

        if (transform.position != spawnOrigin.position)
        {
            transform.position = spawnOrigin.position;
        }


        yarnCommands = FindFirstObjectByType<YarnCommands>();

        for (int i = 0; i < uiButtonsForBrain.Length; i++)
        {
            uiButtonsForBrain[i].SetActive(false);
            yarnCommands.uiButtonsForBrain[i] = uiButtonsForBrain[i];
        }

        playerGameObject = GameObject.FindWithTag("Player");

        Vector3 lookDir = transform.position - playerGameObject.transform.position;
        float radians = Mathf.Atan2(lookDir.x, lookDir.z);
        float degrees = radians * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.Euler(0, degrees - 180, 0);
        transform.rotation = targetRotation;
        
    }
}
