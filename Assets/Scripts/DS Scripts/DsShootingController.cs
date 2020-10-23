using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DS_Scripts
{
    public class DsShootingController : MonoBehaviour
    {
        [SerializeField] private DsMainController mainController;
        
        void Update()
        {
            if (mainController.timeController.isTimeToShoot)
            {
                Shoot();
            }
        
        }
        void Shoot()
        {
            Destroy(mainController.clone);
            mainController.timeController.timeStamp = Time.time + mainController.timeController.projectileCoolDown;
        
            float number = Random.Range(0.1f, 1.0f);
        
            float r = 3 * Mathf.Sqrt(number);
            float angle = Random.Range(0.0f, 1.0f) * 2 * Mathf.PI;

            float x = r * Mathf.Cos(angle);
            float y = r * Mathf.Sin(angle);
        
            mainController.clone = Instantiate(mainController.projectile, gameObject.transform.position + new Vector3(x,y,0),Quaternion.identity);
            mainController.clone.SetActive(true);
        }

        
    }
}