using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private Target[] _targets;
    [SerializeField] private float _spawnInterval = 4f;

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
            foreach (var spawnPoint in _spawnPoints)
            {
                spawnPoint.InitializeEnemy(_targets);
            }

            yield return _waitForSeconds;
        }
    }
}
