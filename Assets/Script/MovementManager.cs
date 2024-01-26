using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [field: SerializeField]
    private UnityEvent<Vector2> moveEvent;
    
    [field: SerializeField]
    private UnityEvent stopMoveEvent;
    
    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("OnMove");
        if (context.performed)
        {
            moveEvent?.Invoke(context.ReadValue<Vector2>());    
        }

        if (context.canceled)
        {
            stopMoveEvent?.Invoke();
        }
    }
}