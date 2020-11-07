using System;
using System.Collections;
using System.Collections.Generic;
using Rat_Scripts;
using UnityEngine;

public class RatTriggerController : MonoBehaviour
{
    [SerializeField] private RatMainController mainController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            mainController.fleeing = true;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            mainController.axyPosition = other.transform.position;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            mainController.fleeing = false;
        }
    }
}
