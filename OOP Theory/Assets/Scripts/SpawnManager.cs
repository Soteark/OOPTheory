using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] float spawnRange = 65.0f;
    [SerializeField] GameObject[] treePrefabs;

    // Start is called before the first frame update
    void Start()
    {
        // spawn a tree every 1 second. if the count of trees is less than or equal to 50
        InvokeRepeating("SpawnTree", 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTree()
    {
        // spawn an object from the treeprefabs array.
        Instantiate(treePrefabs[Random.Range(0, treePrefabs.Length)], new Vector3(Random.Range(-spawnRange, spawnRange), 0, Random.Range(-spawnRange, spawnRange)), Quaternion.identity);
    }
}
