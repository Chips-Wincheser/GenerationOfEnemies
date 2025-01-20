using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;  
    [SerializeField] private float _spawnInterval = 2f;

    private WaitForSeconds _waitForSeconds;

    private void Start()
    {
        _waitForSeconds = new WaitForSeconds(_spawnInterval);
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        bool isWorking = true;

        while (isWorking)
        {
            //Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)].transform;

            foreach (var spawnPoint in _spawnPoints)
            {
                spawnPoint.InitializeEnemy();
            }

            yield return _waitForSeconds;
        }
    }
}
