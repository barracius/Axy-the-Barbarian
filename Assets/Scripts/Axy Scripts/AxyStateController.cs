using System;
using UnityEngine;

namespace Axy_Scripts
{
    public class AxyStateController : MonoBehaviour
    {
        public static event Action AxyDie;
        public static event Action AxyWin;
        
        internal String state = "";

        internal void ChangeState(String newState)
        {
            state = newState;
            if (newState == "Win")
            {
                AxyWin?.Invoke();
            }
            else if (newState == "Dead")
            {
                AxyDie?.Invoke();
            }
        }
    }
}
