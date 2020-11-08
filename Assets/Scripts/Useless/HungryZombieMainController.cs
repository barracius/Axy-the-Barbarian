using System;
using System.Collections;
using System.Collections.Generic;
using Axy_Scripts;
using Pathfinding;
using UnityEngine;

public class HungryZombieMainController : MonoBehaviour
{
    [SerializeField] private AIDestinationSetter _destinationSetter;

    private void Start()
    {
        GameObject axy = GameObject.FindGameObjectWithTag("Player");
        _destinationSetter.target = axy.transform;
    }
}
