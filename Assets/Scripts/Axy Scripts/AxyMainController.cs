using System;
using UnityEngine;

namespace Axy_Scripts
{
    public class AxyMainController : MonoBehaviour
    {
        [SerializeField] internal float movementSpeed = 5;
        [SerializeField] internal AxyInputController inputController;
        [SerializeField] internal AxyPhysicsController physicsController;
        [SerializeField] internal AxyAudioController audioController;
        [SerializeField] internal AxyStateController stateController;
        [SerializeField] internal AxyCollisionController collisionController;

        private void Awake()
        {
            throw new NotImplementedException();
        }
    }
}
