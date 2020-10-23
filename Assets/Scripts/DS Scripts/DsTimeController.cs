using System;
using UnityEditor;
using UnityEngine;
namespace DS_Scripts
{
    public class DsTimeController : MonoBehaviour
    {
        internal double timeStamp;
        internal double projectileCoolDown;
        internal double offsetConstant = 0.5;

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
            GameObject blindGazer = GameObject.Find("Blind Gazer");
            BlindGazer blindGazerScript = blindGazer.GetComponent<BlindGazer>();

            projectileCoolDown = (1 / blindGazerScript.movementSpeed) + offsetConstant;
        }
    }
    
}