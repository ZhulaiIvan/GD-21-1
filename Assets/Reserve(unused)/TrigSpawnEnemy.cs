using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigSpawnEnemy : MonoBehaviour
{
    public GameObject enemyPreFab;
    public Transform spawnPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(enemyPreFab, spawnPoint);
    }
}
