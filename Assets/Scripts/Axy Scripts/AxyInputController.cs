using UnityEngine;

namespace Axy_Scripts
{
    public class AxyInputController : MonoBehaviour
    {
        internal bool IsLeftPressed;
        internal bool IsRightPressed;
        internal bool IsUpPressed;
        internal bool IsDownPressed;

        [SerializeField] private AxyMainController mainController;
    
        private void Update()
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                IsUpPressed = true;
            }
            else
            {
                IsUpPressed = false;
            }
        
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                IsLeftPressed = true;
            }
            else
            {
                IsLeftPressed = false;
            }
        
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                IsRightPressed = true;
            }
            else
            {
                IsRightPressed = false;
            }
        
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                IsDownPressed = true;
            }
            else
            {
                IsDownPressed = false;
            }
        }
    }
}
