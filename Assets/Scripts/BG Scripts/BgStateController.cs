using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BG_Scripts
{
    public class BgStateController : MonoBehaviour
    {
        internal bool _goingUp = false;
        internal bool _hitWall = false;
        
        [SerializeField] private int NumberOfMovements = 100;
        internal float _counter = 0;

        private void Start()
        {
            _counter = NumberOfMovements / 2;
        }

        private void FixedUpdate()
        {
            if (_counter >= NumberOfMovements || _hitWall)
            {
                _goingUp = !_goingUp;
                _counter = 0;
                _hitWall = false;
            }
            
        }
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Wall"))
            {
                _hitWall = true;
            }
        }
    }
}