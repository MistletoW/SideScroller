using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float minSpawnInterval = 1.0f;
    public float maxSpawnInterval = 5.0f;

    private float timer = 0;
    private float spawnInterval;

    void Start()
    {
        SetRandomSpawnInterval();
    }

    void Update()
    {
        if (obstaclePrefab == null)
            return;

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0;
            SetRandomSpawnInterval();
            Vector3 spawnPosition = new Vector3(20, 0, 0);
            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
        }
    }

    private void SetRandomSpawnInterval()
    {
        spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
    }
}


