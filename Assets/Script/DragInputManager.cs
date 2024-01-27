using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Script
{
    public class DragInputManager : MonoBehaviour
    {
        [field: SerializeField]
        private UnityEvent startDrag;
    
        [field: SerializeField]
        private UnityEvent stopDrag;
    
        public void OnDrag(InputAction.CallbackContext context)
        {
        
            if (context.performed)
            {
                startDrag?.Invoke();    
            }

            if (context.canceled)
            {
                stopDrag?.Invoke();
            }
        }
    }
}
