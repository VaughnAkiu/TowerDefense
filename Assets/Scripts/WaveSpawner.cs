using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    //public Transform enemyPrefab;
    public Transform goopMob;
    public Transform goopChunk;

    public Transform spawnPoint;

    private float timeBetweenWaves = 5f;
    private float countdown = 2f;

    private bool spawnAllowed = false;

    private int waveNumber = 1;

    //trying to create a more efficient wave spawner
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while(true)
        {
            SpawnBoss();
            yield return new WaitForSecondsRealtime(5);
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        if (countdown <= 0f)
        {
            SpawnWave();
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;

    }*/

    void SpawnWave ()
    {
        //Debug.Log("Wave Spawned!");
        //SpawnEnemy();
        SpawnBoss();
        waveNumber++;

        if (waveNumber == 20)
        {
            SpawnBoss();
        }

    }

    void SpawnGoopMob()
    {
        Instantiate(goopMob, spawnPoint.position, spawnPoint.rotation);
    }

    void SpawnBoss()
    {
        Instantiate(goopChunk, spawnPoint.position, spawnPoint.rotation);
    }

}
