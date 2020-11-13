using System.Collections;
using System.Collections.Generic;
using Rat_Scripts;
using UnityEngine;

public class RatPhysicsController : MonoBehaviour
{
    [SerializeField] private RatMainController mainController;
    [SerializeField] private float fleeingMovementSpeed = 5;
    [SerializeField] private float wanderingMovementSpeed = 2;
    private int _randomTemp;
    
    
    void FixedUpdate()
    {
        if (mainController.fleeing)
        {
            Flee();
        }
        else
        {
            Wander();
        }
    }

    private void Flee()
    {
        if (mainController.axyPosition.x < transform.position.x)
        {
            transform.Translate(fleeingMovementSpeed * Time.deltaTime * Vector2.right);
        }
        else
        {
            transform.Translate(fleeingMovementSpeed * Time.deltaTime * Vector2.left);
        }

        if (mainController.axyPosition.y < transform.position.y)
        {
            
            transform.Translate(fleeingMovementSpeed * Time.deltaTime * Vector2.up);
        }
        else 
        {
           transform.Translate(fleeingMovementSpeed * Time.deltaTime * Vector2.down); 
        }
    }
    
    private void Wander()
    {
        _randomTemp = Random.Range(0, 3);
        switch (_randomTemp)
        {
            case 0:
                transform.Translate(wanderingMovementSpeed * Time.deltaTime * Vector2.left);
                break;
            case 1:
                transform.Translate(wanderingMovementSpeed * Time.deltaTime * Vector2.right);
                break;
            case 2:
                transform.Translate(wanderingMovementSpeed * Time.deltaTime * Vector2.up);
                break;
            default:
                transform.Translate(wanderingMovementSpeed * Time.deltaTime * Vector2.down); 
                break;
        }
    }
}
