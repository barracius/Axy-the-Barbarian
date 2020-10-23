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
                mainController.stateController.ChangeState("Loss");
            }
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                mainController.stateController.ChangeState("");
            }
        }
    }
}
