using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]private GameObject enemyPrefab;
    [SerializeField] private Transform[] spawnPoints;  
    [SerializeField] private float spawnInterval = 2f;

    private WaitForSeconds _waitForSeconds;

    private void Start()
    {
        _waitForSeconds = new WaitForSeconds(spawnInterval);
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

            Movement enemyMovement = enemy.GetComponent<Movement>();

            if (enemyMovement != null)
            {
                enemyMovement.SetDirection(spawnPoint.forward);
            }

            yield return _waitForSeconds;
        }
    }
}
