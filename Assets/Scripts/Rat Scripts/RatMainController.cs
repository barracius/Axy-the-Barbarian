using System;
using UnityEngine;

namespace Rat_Scripts
{
    public class RatMainController : MonoBehaviour
    {
        [SerializeField] internal RatTriggerController triggerController;
        [SerializeField] internal RatPhysicsController physicsController;
        [SerializeField] internal RatDecisionController decisionController;
        public bool fleeing; //false = wandering, true = fleeing
        internal Transform axy = null;
        [SerializeField] internal float fleeingMovementSpeed = 5f;
        [SerializeField] internal float wanderingMovementSpeed = 2f;
        [SerializeField] internal float fleeDistance = 5f;
        [SerializeField] internal float attackDistance = 6f;

        private void Start()
        {
            fleeing = false;
            axy = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
}
