using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Mover _enemyPrefab;

    public void InitializeEnemy(Target[] targets)
    {
        Mover enemy = Instantiate(_enemyPrefab, transform.position, transform.rotation);
        enemy.AssigningTarget(targets[Random.Range(0, targets.Length)].transform);
    }
}
