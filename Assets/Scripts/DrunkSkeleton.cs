using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrunkSkeleton : MonoBehaviour
{
    public int projectileCoolDown;

    public GameObject projectile;

    private int projectileDistance = 3;
    private float timeStamp;

    // Start is called before the first frame update
    void Start()
    {
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
        timeStamp = Time.time + projectileCoolDown;
       
        int x = Random.Range(-3, 4);
        int y = Random.Range(-3, 4);
        while (x==0 && y==0)
        {
            x = Random.Range(-3, 4);
            y = Random.Range(-3, 4);
        }
        projectile.transform.position = gameObject.transform.position;
        projectile.transform.position += new Vector3(x,y,0);
        
    }
}
