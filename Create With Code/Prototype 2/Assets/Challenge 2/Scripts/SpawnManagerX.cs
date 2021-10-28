using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    public float timer;

    private float minTime = 3.0f;
    private float maxTime = 5.0f;

    private float startDelay = 1.0f;
    public float spawnInterval;

    void Start()
    {
        spawnInterval = Random.Range(minTime, maxTime);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            SpawnRandomBall();
            spawnInterval = Random.Range(minTime, maxTime);
            timer = 0;
            // Commented out the following line to remove InvokeRepeating command
            //InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(1.0f, 5.0f));
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }


}
