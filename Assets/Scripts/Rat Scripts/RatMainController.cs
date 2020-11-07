using System;
using UnityEngine;

namespace Rat_Scripts
{
    public class RatMainController : MonoBehaviour
    {
        [SerializeField] internal RatTriggerController triggerController;
        [SerializeField] internal RatPhysicsController physicsController;
        internal bool fleeing; //false = wandering, true = fleeing
        internal Vector2 axyPosition;

        private void Start()
        {
            fleeing = false;
        }
    }
}
