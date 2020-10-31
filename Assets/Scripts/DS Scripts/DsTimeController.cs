using System;
using BG_Scripts;
using UnityEditor;
using UnityEngine;
namespace DS_Scripts
{
    public class DsTimeController : MonoBehaviour
    {
        internal double timeStamp;
        internal double projectileCoolDown;
        public double offsetConstant = 0.5;

        internal bool isTimeToShoot;

        private void Start()
        {
            calculateSpeedOffset();
        }

        private void Update()
        {
            if (timeStamp <= Time.time)
            {
                isTimeToShoot = true;
            }
            else
            {
                isTimeToShoot = false;
            }
        }

        void calculateSpeedOffset()
        {
            projectileCoolDown =  offsetConstant;
        }
    }
    
}