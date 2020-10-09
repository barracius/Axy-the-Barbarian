using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrunkSkeleton : MonoBehaviour
{
    

    public GameObject projectile;

    [SerializeField] private int projectileDistance = 3;
    private float timeStamp;
    private GameObject clone;
    private float projectileCoolDown;
    private float offsetConstant = 1;

    // Start is called before the first frame update
    void Start()
    {
        calculateSpeedOffset();
        projectile.SetActive(false);
        Shoot();

    }

    // Update is called once per frame
    void Update()
    {
        if (timeStamp <= Time.time)
        {
            Shoot();
        }
        
    }
    void Shoot()
    {
        Destroy(clone);
        timeStamp = Time.time + projectileCoolDown;
       
        int x = Random.Range(-projectileDistance, projectileDistance + 1);
        int y = Random.Range(-projectileDistance, projectileDistance + 1);
        while (x==0 && y==0)
        {
            x = Random.Range(-projectileDistance, projectileDistance + 1);
            y = Random.Range(-projectileDistance, projectileDistance + 1);
        }
        clone = Instantiate(projectile, gameObject.transform.position + new Vector3(x,y,0),Quaternion.identity);
        clone.SetActive(true);
    }

    void calculateSpeedOffset()
    {
        GameObject blindGazer = GameObject.Find("Blind Gazer");
        BlindGazer blindGazerScript = blindGazer.GetComponent<BlindGazer>();

        projectileCoolDown = (1 / blindGazerScript.movementSpeed) + offsetConstant;
    }
}
