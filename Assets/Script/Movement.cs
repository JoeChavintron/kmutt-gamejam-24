using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private bool _isMoving;
    private Vector2 _direction;

    public float speed = 100f;

    public Rigidbody body;
    
    private void Update()
    {
        if (!_isMoving)
        {
            body.velocity = Vector3.zero;
            return;
        }
        body.velocity = new Vector3(_direction.x*speed, 0, _direction.y*speed);
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
