using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private float _speed = 6f;

    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;

    }
}
