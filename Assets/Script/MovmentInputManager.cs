using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class MovmentInputManager : MonoBehaviour
{
    [field: SerializeField]
    private UnityEvent<Vector2> moveEvent;
    
    [field: SerializeField]
    private UnityEvent stopMoveEvent;
    
    public void OnMove(InputAction.CallbackContext context)
    {
        
        if (context.performed)
        {
            moveEvent?.Invoke(context.ReadValue<Vector2>());    
        }

        if (context.canceled)
        {
            Debug.Log("OnStopMove");
            stopMoveEvent?.Invoke();
        }
    }
}