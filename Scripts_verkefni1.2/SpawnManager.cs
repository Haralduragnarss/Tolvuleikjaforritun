using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // Array fyrir object búið til
    private float spawnRangeX = 20;
    private float spawnPoaZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); // Kallar á fall á ákveðnu rate-i og spawnar dýrum random
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal() // Fallið sem spawnar random dýrum skilgreint
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); // Random tala á bili fengin
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPoaZ); // Ný staðsetning fundið og gerð
        Instantiate(animalPrefabs[animalIndex], spawnPos,
        animalPrefabs[animalIndex].transform.rotation);
    }
}
