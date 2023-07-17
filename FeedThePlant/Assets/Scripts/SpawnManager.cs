using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
    private int obstacleIndex;
    private Vector3 spawnPos;
    private float randomX;
    private float yPos;
    private float startDelay = 1;
    private float spawnRate = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacle()
    {
        obstacleIndex = Random.Range(0, obstacles.Length);
        randomX = Random.Range(-2.5f,2.5f);
        yPos = 5;
        spawnPos = new Vector3(randomX, yPos, -0.1f);
        Instantiate(obstacles[obstacleIndex], spawnPos, obstacles[obstacleIndex].transform.rotation);
    }
}
