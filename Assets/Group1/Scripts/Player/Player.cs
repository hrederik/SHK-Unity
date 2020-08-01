using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _transform;
    
    private void Start()
    {
        _transform = transform;
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(x, y);

        Move(direction);
    }

    private void Move(Vector2 direction)
    {
        _transform.Translate(direction * _speed * Time.deltaTime);
    }
}
