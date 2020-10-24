using System;
using UnityEditor;
using UnityEngine;

namespace Axy_Scripts
{
    public class AxyAudioController : MonoBehaviour
    {
        [SerializeField] private AxyMainController mainController;
        [SerializeField] private AudioSource deathSound;
        [SerializeField] private AudioSource victorySound;

        // Update is called once per frame
        void Update()
        {
            if (mainController.stateController.state.Equals("Dead"))
            {
                deathSound.Play();
                mainController.stateController.ChangeState("Restart");
            }

            if (mainController.stateController.state.Equals("Win"))
            {
                victorySound.Play();
                mainController.stateController.ChangeState("Won");
            }
        }
    }
}
