using Axy_Scripts;
using UnityEngine;

namespace Game_Controller_Scripts
{
    
    public class AudioController : MonoBehaviour
    {
        
        [SerializeField] private AudioSource deathSound;
        [SerializeField] private AudioSource victorySound;
        
        public void Start()
        {
            AxyStateController.AxyDie += AxyDieSound;
            AxyStateController.AxyWin += AxyWinSound;
        }

        void AxyDieSound()
        {
            deathSound.Play();
        }

        void AxyWinSound()
        {
            victorySound.Play();

        }
    }
}