using System;
using Axy_Scripts;
using UnityEngine;
using UnityEngine.UI;

namespace Game_Controller_Scripts
{
    public class WinLooseController : MonoBehaviour
    {
        [SerializeField] internal Image blackScreen;

        public void Start()
        {
            AxyStateController.AxyDie += Die;
            AxyStateController.AxyWin += Win;
        }

        public void Win()
        {
            while (blackScreen.color.a < 1)
            {
                blackScreen.color += new Color(0, 0, 0, (float)0.05);
                    
            }
        }

        public void Die()
        {
            
        }
    }
}