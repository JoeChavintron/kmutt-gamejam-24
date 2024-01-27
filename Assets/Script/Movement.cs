using UnityEngine;

public class Movement : MonoBehaviour
{
    private bool _isMoving;
    private Vector2 _direction;

    public float speed = .01f;
    
    private void Update()
    {
        if (!_isMoving) return;
        transform.position = new Vector3(transform.position.x + _direction.x * speed, transform.position.y, transform.position.z + _direction.y * speed);
    }

    public void OnMove(Vector2 direction)
    {
        _isMoving = true;
        _direction = direction;
    }

    public void OnStopMove()
    {
        _isMoving = false;
    }
}
