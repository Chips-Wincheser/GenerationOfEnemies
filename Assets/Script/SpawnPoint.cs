using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform _targetPoint;
    [SerializeField] private Movement _enemyPrefab;

    public void InitializeEnemy()
    {
        Movement enemy = Instantiate(_enemyPrefab, transform.position, transform.rotation);

        enemy.SetDirection(_targetPoint.forward);
    }
}
