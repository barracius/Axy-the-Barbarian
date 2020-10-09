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
            Debug.Log("arriba");
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.up);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("izq");
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.left);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("der");
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.right);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("abajo");
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.down);
        }
    }
    
    
}
