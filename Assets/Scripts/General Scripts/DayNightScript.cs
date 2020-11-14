using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightScript : MonoBehaviour
{
    private Camera _camera;
    public float dayNightDuration = 5f;
    public bool isNight = false;
    private float _timeStartOfCycle;
    
    void Start()
    {
        _camera = transform.GetComponent<Camera>();
        _camera.backgroundColor = isNight ? Color.black : Color.yellow;
        _timeStartOfCycle = Time.time;
    }

    private void Update()
    {
        if (!(Time.time - _timeStartOfCycle >= dayNightDuration)) return;
        if (isNight)
        {
            isNight = false;
            _camera.backgroundColor = Color.yellow;
        }
        else
        {
            isNight = true;
            _camera.backgroundColor = Color.black;
        }
        _timeStartOfCycle = Time.time;
    }
}
