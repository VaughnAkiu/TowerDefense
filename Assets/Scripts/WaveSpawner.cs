using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public Transform enemyPrefab;

    public Transform spawnPoint;

    private float timeBetweenWaves = 5f;
    private float countdown = 2f;

    private int waveNumber = 1;

    // Update is called once per frame
    void Update()
    {
        if (countdown <= 0f)
        {
            SpawnWave();
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;

    }

    void SpawnWave ()
    {
        Debug.Log("Wave Spawned!");
        SpawnEnemy();
        waveNumber++;

    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

}
