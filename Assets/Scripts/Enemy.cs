using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private float _speed;

    void Update() =>
        transform.position = Vector3.MoveTowards(transform.position, _endPosition, _speed * Time.deltaTime);

    public void Init(Vector3 endPosition) =>
        _endPosition = endPosition;
}
