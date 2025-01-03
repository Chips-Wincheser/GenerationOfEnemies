using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private Vector3 direction;

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection.normalized;
    }
}
