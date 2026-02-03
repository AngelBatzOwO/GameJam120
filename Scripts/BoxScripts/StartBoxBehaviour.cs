using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBoxBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject bubbles;

    [SerializeField]
    GameObject rocks;

    void Start()
    {
        InvokeRepeating("SpawnBubbles", 4f, 2f);
        InvokeRepeating("SpawnRocks", 2f, 1f);
    }

    
    void SpawnRocks()
    {
        Vector3 randomSpawnPosition = new Vector3(30, Random.Range(-12, 13), -6);

        Instantiate(rocks, randomSpawnPosition, Quaternion.identity);
    }

    void SpawnBubbles()
    {
        Vector3 randomSpawnPosition = new Vector3(30, Random.Range(-12, 13), -6);
        Instantiate(bubbles, randomSpawnPosition, Quaternion.identity);
          
    }
}
