using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Vector3[] spawnLocations;
    public GameObject[] spawnInitializer;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPrefabs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPrefabs()
    {
        for (int i = 0; i < spawnLocations.Length; i++)
        {
            Instantiate(enemy, spawnLocations[i], enemy.transform.rotation);

            Instantiate(spawnInitializer[i], spawnLocations[i], spawnInitializer[i].transform.rotation);
        }
    }
}
