using System;
using UnityEngine;

namespace Axy_Scripts
{
    public class AxyStateController : MonoBehaviour
    {
        internal String state = "";

        internal void ChangeState(String newState)
        {
            state = newState;
        }
    }
}
