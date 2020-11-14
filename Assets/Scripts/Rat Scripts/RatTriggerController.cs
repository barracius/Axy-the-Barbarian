using UnityEngine;

namespace Rat_Scripts
{
    public class RatTriggerController : MonoBehaviour
    {
        [SerializeField] private RatMainController mainController;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                mainController.fleeing = true;
            }
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                mainController.axy = other.transform;
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                mainController.fleeing = false;
            }
        }
    }
}
