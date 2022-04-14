using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController playerControllerScript;

    public GameObject obstaclePrab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    public float startDelay = 2.0f;
    public float repeatRate = 2.0f;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrab, spawnPos, obstaclePrab.transform.rotation);
        }
    }
}
