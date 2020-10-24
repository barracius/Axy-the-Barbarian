using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BG_Scripts
{
    public class BgMovementController : MonoBehaviour
    {
        public float movementSpeed = 5;

        [SerializeField] private BgMainController mainController;

        private void FixedUpdate()
        {
            Patrol();
        }
        
        void Patrol()
        {
            if (mainController.stateController._goingUp)
            {
                transform.Translate(movementSpeed * Time.deltaTime * Vector3.up);
                mainController.stateController._counter++;
            }
            else
            {
                transform.Translate(movementSpeed * Time.deltaTime * Vector3.down);
                mainController.stateController._counter++;
            }

            
        }
    }
}