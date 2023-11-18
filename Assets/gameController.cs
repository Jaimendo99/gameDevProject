
using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints; // Array to hold spawn points
    public float minSpawnTime = 2f; // Minimum time between spawns
    public float maxSpawnTime = 5f; // Maximum time between spawns

    private void Start()
    {
        // Start the coroutine to spawn enemies at random intervals
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            // Wait for a random amount of time within the defined range
            float spawnDelay = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(spawnDelay);

            // Choose a random spawn point from the array
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            // Instantiate an enemy at the selected spawn point's position
            Instantiate(enemyPrefab, randomSpawnPoint.position, Quaternion.identity);
        }
    }
}
