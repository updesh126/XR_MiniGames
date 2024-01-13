using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_FruitSpawnOverTable : MonoBehaviour
{
    public GameObject[] fruitPrefab;
    public Transform treeTransform;
    public float spawnInterval = 2.0f;
    public float spawnRateIncreaseInterval = 30.0f;
    private float timeSinceLastSpawn = 0.0f;
    private Rigidbody rb;
    private float spawnTime = 0.0f;
    public Transform[] RandomPositions;

    private void Start()
    {
        SpawnFruit();
        
    }
    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        spawnTime += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnFruit();
            timeSinceLastSpawn = 0.1f;
        }

    }

    private void SpawnFruit()
    {
        int randomIndex = Random.Range(0, fruitPrefab.Length);
        GameObject Fruit = fruitPrefab[randomIndex];
        Vector3 spawnPosition = CalculateSpawnPosition();
        Instantiate(Fruit, spawnPosition, Quaternion.identity);
    }

    private Vector3 CalculateSpawnPosition()
    {
        int randomIndex = Random.Range(0, RandomPositions.Length);
        Vector3 randomOffset = RandomPositions[randomIndex].position;
        return randomOffset;
    }
}
