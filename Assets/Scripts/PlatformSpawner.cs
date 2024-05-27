using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    /*public GameObject platformPrefab;
    public GameObject spikePlatformPrefab;
    public GameObject leftBoostingPlatformPrefab;
    public GameObject rightBoostingPlatformPrefab;
    public GameObject breakablePlatformPrefab;
    public GameObject coinPrefab; // Add a reference to the coin prefab

    public float platform_Spawn_Timer = 2f;
    private float currentPlatformSpawnTimer;
    
    private float coinSpawnChance = 0.5f; // Chance for a coin to spawn on a platform

    private int platform_Spawn_Count;

    public float min_X = -1.5f, max_X = 1.5f;

    void Start()
    {
        currentPlatformSpawnTimer = platform_Spawn_Timer;
    }

    void Update()
    {
        SpawnPlatforms();
    }

    void SpawnPlatforms()
    {
        currentPlatformSpawnTimer += Time.deltaTime;

        if (currentPlatformSpawnTimer >= platform_Spawn_Timer)
        {
            platform_Spawn_Count++;

            Vector3 temp = transform.position;
            temp.x = Random.Range(min_X, max_X);

            GameObject newPlatform = null;

            if (platform_Spawn_Count % 5 == 0)
            {
                // Spawn an unusual platform
                int randomPlatformType = Random.Range(1, 4);

                switch (randomPlatformType)
                {
                    case 1:
                        newPlatform = Instantiate(spikePlatformPrefab, temp, Quaternion.identity);
                        break;
                    case 2:
                        newPlatform = Instantiate(leftBoostingPlatformPrefab, temp, Quaternion.identity);
                        break;
                    case 3:
                        newPlatform = Instantiate(rightBoostingPlatformPrefab, temp, Quaternion.identity);
                        break;
                    case 4:
                        newPlatform = Instantiate(breakablePlatformPrefab, temp, Quaternion.identity);
                        break;
                }
            }
            else
            {
                // Spawn a regular platform
                newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
            }

            // Potentially spawn a coin on the platform
            if (Random.value < coinSpawnChance)
            {
                Instantiate(coinPrefab, newPlatform.transform.position, Quaternion.identity);
            }

            currentPlatformSpawnTimer = 0f;
        }
    } */

    public GameObject[] obj;

    public float timeSpawn = 3f;
    private float timer;
    public float min_X = -1.5f, max_X = 1.5f;

    private void Start()
    {
        timer = timeSpawn;
        
    }

    private void Update()
    {
        Vector3 temp = transform.position;
        temp.x = Random.Range(min_X, max_X);

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = timeSpawn;
            int random = Random.Range(0, obj.Length - 1);
            Instantiate(obj[random], temp, Quaternion.identity, transform);
        }
    }










}


