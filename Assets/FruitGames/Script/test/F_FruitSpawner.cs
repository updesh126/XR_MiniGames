using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject fruitPrefab; // The prefab of the fruit to spawn
    public Transform treeTransform; // The transform of the tree where the fruit will spawn
    public float initialSpawnRate = 2.0f; // Initial spawn rate in seconds
    public float spawnRateIncreaseInterval = 10.0f; // Interval to increase spawn rate
    public float spawnRateIncreaseAmount = 0.2f; // Amount to increase spawn rate

    public Transform[] spawnPositions; // Array of positions around the tree to spawn fruit

    private float currentSpawnRate;

    private void Start()
    {
        currentSpawnRate = initialSpawnRate;
        StartCoroutine(SpawnFruit());
        StartCoroutine(IncreaseSpawnRate());
    }

    private IEnumerator SpawnFruit()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, spawnPositions.Length);
            Vector3 randomSpawnPosition = spawnPositions[randomIndex].position;
            Instantiate(fruitPrefab, randomSpawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(currentSpawnRate);
        }
    }

    private IEnumerator IncreaseSpawnRate()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRateIncreaseInterval);
            currentSpawnRate -= spawnRateIncreaseAmount;
            if (currentSpawnRate < 0.1f) // Ensure spawn rate doesn't become too fast
            {
                currentSpawnRate = 0.1f;
            }
        }
    }

}
