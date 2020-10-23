using System;
using UnityEngine;

namespace DS_Scripts
{
    public class DsMainController : MonoBehaviour
    {
        [SerializeField] internal DsTimeController timeController;
        [SerializeField] internal DsShootingController shootingController;
        
        public GameObject projectile;
        internal GameObject clone;
        

        private void Awake()
        {
            projectile.SetActive(false);
            
        }
    }
}