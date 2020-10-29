using System;
using UnityEngine;

namespace Axy_Scripts
{
    public class AxyPhysicsController : MonoBehaviour
    {
        [SerializeField] private float movementSpeed = 5;
        [SerializeField] private AxyMainController mainController;
        private Vector2 _startingPosition;

        private void Start()
        {
            _startingPosition = transform.position;
            AxyStateController.AxyDie += GoToStart;
        }

        private void FixedUpdate()
        {
            if (mainController.inputController.IsLeftPressed)
            {
                transform.Translate(movementSpeed * Time.deltaTime * Vector3.left);
            }

            if (mainController.inputController.IsRightPressed)
            {
                transform.Translate(movementSpeed * Time.deltaTime * Vector3.right);
            }
        
            if (mainController.inputController.IsUpPressed)
            {
                transform.Translate(movementSpeed * Time.deltaTime * Vector3.up);
            }
        
            if (mainController.inputController.IsDownPressed)
            {
                transform.Translate(movementSpeed * Time.deltaTime * Vector3.down);
            }
            
        }

        void GoToStart()
        {
            transform.position = _startingPosition;
        }
    }
}
