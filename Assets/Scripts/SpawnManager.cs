using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] giftsPrefabs;
    float zRange = 5.0f;
    float ySpawnBound = 9.0f;
    float xPos = 7;
    float startDelay = 1.0f;
    float spawnRate = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        //Invoke the method each 2 seconds starting with 1 second
        InvokeRepeating("SpawnGifts", startDelay, spawnRate);
    }

    //Spawns gameObjects at a random position on a predefined X position
    void SpawnGifts()
    {
        Vector3 randomPos = new Vector3(xPos, ySpawnBound, Random.Range(-zRange, zRange));
        int index = Random.Range(0, giftsPrefabs.Length);
        Instantiate(giftsPrefabs[index], randomPos, giftsPrefabs[index].transform.rotation);
    }

}
