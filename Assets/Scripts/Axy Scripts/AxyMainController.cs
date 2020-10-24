using System;
using UnityEngine;
using UnityEngine.UI;

namespace Axy_Scripts
{
    public class AxyMainController : MonoBehaviour
    {
        [SerializeField] internal AxyInputController inputController;
        [SerializeField] internal AxyPhysicsController physicsController;
        [SerializeField] internal AxyAudioController audioController;
        [SerializeField] internal AxyStateController stateController;
        [SerializeField] internal AxyCollisionController collisionController;
        [SerializeField] internal Image blackScreen;
        //private float _blackScrenRate = float0.05;
        

        private void Update()
        {
            if (stateController.state.Equals("Won"))
            {
                // pausar
                while (blackScreen.color.a < 1)
                {
                    blackScreen.color += new Color(0, 0, 0, (float)0.05);
                    
                }
            }
        }
    }
}
