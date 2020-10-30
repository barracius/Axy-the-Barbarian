using System;
using UnityEngine;

namespace Axy_Scripts
{
    public class AxyMainController : MonoBehaviour
    {
        [SerializeField] internal AxyInputController inputController;
        [SerializeField] internal AxyPhysicsController physicsController;
        [SerializeField] internal AxyStateController stateController;
        [SerializeField] internal AxyCollisionController collisionController;
        //private float _blackScrenRate = float0.05;

        private void Awake()
        {
            
        }
    }
}
