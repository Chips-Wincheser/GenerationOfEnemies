using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed=5;
    private Transform _player;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _player.position,_speed * Time.deltaTime);
    }

    public void AssigningTarget(Transform target)
    {
        _player=target;
    }
}