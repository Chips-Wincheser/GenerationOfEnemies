using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _wayPoints;
    [SerializeField] private float _speed;
    [SerializeField] private float _stopThreshold = 0.1f;

    private int _currentWaypoint = 0;

    private void Update()
    {
        if (Vector3.Distance(transform.position, _wayPoints[_currentWaypoint].position)<_stopThreshold)
        {
            _currentWaypoint = (_currentWaypoint + 1) % _wayPoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position,_wayPoints[_currentWaypoint].position,
            _speed * Time.deltaTime);
    }
}
