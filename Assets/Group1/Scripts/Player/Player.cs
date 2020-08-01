using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _defaultSpeed;
    private Transform _transform;

    private void Start()
    {
        _transform = transform;
        _defaultSpeed = _speed;
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(x, y);

        Move(direction);
    }

    public void SetSpeed(float targetSpeed)
    {
        _speed = targetSpeed;
    }

    public void Stop()
    {
        SetSpeed(0);
    }

    public void ResetSpeed()
    {
        _speed = _defaultSpeed;
    }

    private void Move(Vector2 direction)
    {
        _transform.Translate(direction * _speed * Time.deltaTime);
    }
}
