using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public int spawn_time_upper = 10;
    public int spawn_time_lower = 1;
    float _timer = 0f;

    private float _spawnInterval;
    // Start is called before the first frame update
    void Start()
    {
        spawn_time_upper = Random.Range(5, 15);
        _spawnInterval = Random.Range(spawn_time_lower, spawn_time_upper);
        InvokeRepeating("SpawnEnemy", Random.Range(spawn_time_lower, spawn_time_upper), Random.Range(spawn_time_lower, spawn_time_upper));
    }

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _spawnInterval)
        {
            SpawnEnemy();
            _timer = 0f;
            _spawnInterval = Random.Range(spawn_time_lower, spawn_time_upper);
        }
        
        spawn_time_upper = Random.Range(5, 20);
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, transform.position, Quaternion.Euler(0,0,90));
    }
}
