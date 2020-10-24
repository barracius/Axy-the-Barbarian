using System;
using UnityEngine;

namespace Axy_Scripts
{
    public class AxyCollisionController : MonoBehaviour
    {
        [SerializeField] private AxyMainController mainController;
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                mainController.stateController.ChangeState("Dead");
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Finish"))
            {
                mainController.stateController.ChangeState("Win");
            }
        }
    }
}
