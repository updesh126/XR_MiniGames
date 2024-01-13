using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class F_FruitSpawning : MonoBehaviour
{
    public GameObject fruitPrefab;
    public Transform treeTransform; 
    public float spawnInterval = 2.0f;
    public float spawnRateIncreaseInterval = 30.0f;
    private float timeSinceLastSpawn = 0.0f;
    private float spawnTime = 0.0f;
    private Rigidbody rb;

    public Transform[] RandomPositions;
    

    private void Start()
    {
        SpawnFruit();
        rb = fruitPrefab.GetComponent<Rigidbody>();
        rb.useGravity = false;
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
        
        Vector3 spawnPosition = CalculateSpawnPosition();

        
        Instantiate(fruitPrefab, spawnPosition, Quaternion.identity);
    }

    private Vector3 CalculateSpawnPosition()
    {

        /*Vector3 randomOffset = new Vector3(
            Random.Range(-0.5f, 0.5f),
            //Random.Range(0.5f, 1.0f),
            1.0f,
            Random.Range(-0.5f, 0.5f)
        );*/
        int randomIndex = Random.Range(0, RandomPositions.Length);
        Vector3 randomOffset = RandomPositions[randomIndex].position;


        //Vector3 spawnPosition = treeTransform.TransformPoint(randomOffset);

        //return spawnPosition;
        return randomOffset;
    }
    

    private IEnumerator IncreaseSpawnRate()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRateIncreaseInterval);
            spawnInterval -= .1f;
            if (spawnInterval < 0.1f) // Ensure spawn rate doesn't become too fast
            {
                spawnInterval = 0.1f;
            }
        }
    }
}
