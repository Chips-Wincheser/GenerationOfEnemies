using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Movement _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;  
    [SerializeField] private float _spawnInterval = 2f;

    private WaitForSeconds _waitForSeconds;

    private void Start()
    {
        _waitForSeconds = new WaitForSeconds(_spawnInterval);
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];

            Movement enemy = Instantiate(_enemyPrefab, spawnPoint.position, spawnPoint.rotation);

            Movement enemyMovement = enemy.GetComponent<Movement>();

            if (enemyMovement != null)
            {
                enemyMovement.SetDirection(spawnPoint.forward);
            }

            yield return _waitForSeconds;
        }
    }
}
