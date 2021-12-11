using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(enemyPrefab, spawnPoint);    
    }
}
