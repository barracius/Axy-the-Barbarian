using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindGazer : MonoBehaviour
{
    private bool _goingUp = false;
    private bool _hitWall = false;

    public float movementSpeed = 5;

    [SerializeField] private int NumberOfMovements = 100;
    private float _counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        _counter = NumberOfMovements / 2;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Patrol();
    }

    void Patrol()
    {
        if (_goingUp)
        {
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.up);
            _counter++;
        }
        else
        {
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.down);
            _counter++;
        }

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
