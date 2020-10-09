using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axy : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        inputListener();
    }

    void inputListener()
    {
        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.up);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.left);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.right);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.down);
        }
    }
    
    
}
