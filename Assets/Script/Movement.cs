using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Movement : MonoBehaviour
{

    [field: SerializeField]
    public DrawLineController drawLineController;

    private bool _isMoving;
    private Vector2 _direction;

    public float originSpeed = 10f;
    public float draggingSpeed = 5;
    
    private float _currentSpeed;

    public Rigidbody body;

    private void Start()
    {
        _currentSpeed = originSpeed;
    }

    private void Update()
    {
        if (!_isMoving)
        {
            body.velocity = Vector3.zero;
            return;
        }

        body.velocity = new Vector3(_direction.x * _currentSpeed, 0, _direction.y * _currentSpeed);
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

    public void OnDrag()
    {
        _currentSpeed = draggingSpeed;
        drawLineController.isDraw = true;
    }

    public void OnStopDrag()
    {
        Debug.Log("stop drag");
        _currentSpeed = originSpeed;
        drawLineController.isDraw = false;
    }
}