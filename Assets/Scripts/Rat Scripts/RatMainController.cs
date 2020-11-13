using System;
using UnityEngine;

namespace Rat_Scripts
{
    public class RatMainController : MonoBehaviour
    {
        [SerializeField] internal RatTriggerController triggerController;
        [SerializeField] internal RatPhysicsController physicsController;
        public bool fleeing; //false = wandering, true = fleeing
        public static bool sFlee;
        internal Vector2 axyPosition;

        private void Start()
        {
            fleeing = false;
        }

        private void Update()
        {
            sFlee = fleeing;

        }
    }
}
