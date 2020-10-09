using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindGazer : MonoBehaviour
{
    private bool goingUp = false;

    public float movementSpeed = 5;

    [SerializeField] private int NumberOfMovements = 5;
    private float counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        counter = NumberOfMovements / 2;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Patrol();
    }

    void Patrol()
    {
        if (goingUp)
        {
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.up);
            counter++;
        }
        else
        {
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.down);
            counter++;
        }

        if (counter >= NumberOfMovements)
        {
            goingUp = !goingUp;
            counter = 0;
        }
    }
}
