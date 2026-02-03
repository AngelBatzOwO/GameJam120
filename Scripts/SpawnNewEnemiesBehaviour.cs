using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewEnemiesBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;

   
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 15f, 15f);
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
    
}
