using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    //public Transform enemyPrefab;
    public Transform goopMob;
    public Transform goopChunk;

    public Transform spawnPoint;

    //private float timeBetweenWaves = 5f;
    //private float countdown = 2f;

    private bool spawnAllowed = false;
    private bool currentlySpawning = false;

    private int waveNumber = 1;

    //function that goes with next wave button
    public void TriggerSpawn()
    {
        //make sure cant spawn while already spawning
        if (currentlySpawning == false)
        {
            if (waveNumber == 1)
            {
                StartCoroutine(SpawnLevelOne());
                ChangeWaveLevelText();
                currentlySpawning = true;
            }
            else if (waveNumber == 2)
            {
                StartCoroutine(SpawnLevelTwo());
                ChangeWaveLevelText();
                currentlySpawning = true;
            }
            else if (waveNumber == 3)
            {
                StartCoroutine(SpawnLevelThree());
                ChangeWaveLevelText();
                currentlySpawning = true;
            }
        }
    }

    /*
     * ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
     * WAVE LEVELS
     * ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
     * */
    //trying to create a more efficient wave spawner
    IEnumerator SpawnLevelOne()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSecondsRealtime(2);
            SpawnGoopMob();
        }
        StopCoroutine(SpawnLevelOne());
        currentlySpawning = false;
        waveNumber++;
    }
    
    IEnumerator SpawnLevelTwo()
    {
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSecondsRealtime(1);
            SpawnGoopMob();
        }
        StopCoroutine(SpawnLevelTwo());
        currentlySpawning = false;
        waveNumber++;
    }

    IEnumerator SpawnLevelThree()
    {
        for (int i = 0; i < 1; i++)
        {
            yield return new WaitForSecondsRealtime(5);
            SpawnGoopChunk();
        }
        StopCoroutine(SpawnLevelThree());
        currentlySpawning = false;
        waveNumber++;
    }
    /*
 * ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 * WAVE LEVELS
 * ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 * */



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
        SpawnGoopChunk();
        waveNumber++;

        if (waveNumber == 20)
        {
            SpawnGoopChunk();
        }

    }

    void ChangeWaveLevelText ()
    {
        PlayerStats.waveLevel = waveNumber;
        PlayerStats.instance.ChangeWaveLevelText();
    }

    void SpawnGoopMob()
    {
        Instantiate(goopMob, spawnPoint.position, spawnPoint.rotation);
    }

    void SpawnGoopChunk()
    {
        Instantiate(goopChunk, spawnPoint.position, spawnPoint.rotation);
    }

}
