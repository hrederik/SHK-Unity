using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _availableAreaRadius = 4.0f;
    [SerializeField] private float _speed = 2.0f;
    private Transform _transform;
    private Vector3 _target;

    private void Start()
    {
        _transform = transform;
        _target = Random.insideUnitCircle * _availableAreaRadius;
    }

    private void FixedUpdate()
    {
        _transform.position = Vector3.MoveTowards(_transform.position, _target, _speed * Time.deltaTime);
        
        if (_transform.position == _target)
            _target = Random.insideUnitCircle * _availableAreaRadius;
    }

    public void Kill()
    {
        Destroy(gameObject);
    }
}