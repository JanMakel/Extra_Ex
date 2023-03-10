using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;
    private float RandomBool;
    private float RandomX;

    private PlayerControllerX playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
        
    }

    // Spawn obstacles
    void SpawnObjects()
    {
        
        // Set random spawn location and random object index
        Vector3 spawnLocation = new Vector3(RandomX, Random.Range(3, -9), 0);
        int index = Random.Range(0, objectPrefabs.Length);

        

        if (RandomBool == 0)
        {
            RandomX = 14;
        }
        if (RandomBool == 1)
        {
            RandomX = -14;
        }




        // If game is still active, spawn new object
        if (!playerControllerScript.gameOver)
        {
            Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        }

    }

    private void Update()
    {
        RandomBool = Random.Range(0, 2);
    }
}
