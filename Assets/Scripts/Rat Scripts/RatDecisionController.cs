using System;
using System.Collections.Generic;
using General_Scripts;
using Rat_Scripts;
using Rat_Scripts.Nodes;
using UnityEngine;

namespace Rat_Scripts
{
    public class RatDecisionController:MonoBehaviour
    {
        [SerializeField] private RatMainController mainController;
        private Node _topNode;
        private NightNode _nightNode;
        private NearNode _dayNearNode;
        private NearNode _nightNearNode;
        private FleeNode _fleeNode;
        private WanderNode _wanderNode;
        private AttackNode _attackNode;
        private void ConstructDecisionTree()
        {
            var transform1 = transform;
            _dayNearNode = new NearNode(transform1, mainController.axy, mainController.fleeDistance);
            _nightNearNode = new NearNode(transform1, mainController.axy, mainController.attackDistance);
            _nightNode = new NightNode(GameObject.FindGameObjectWithTag("MainCamera").transform);
            _attackNode = new AttackNode(transform1, mainController.axy);
            _fleeNode = new FleeNode(transform1);
            _wanderNode = new WanderNode(transform1);
        }

        private void Start()
        {
            ConstructDecisionTree();
        }

        private void Update()
        {
            if (_nightNode.Evaluate() == NodeStates.SUCCESS )
            {
                if (_nightNearNode.Evaluate() == NodeStates.SUCCESS)
                {
                    _attackNode.Evaluate();
                }
                else
                {
                    _wanderNode.Evaluate();
                }
            }
            else
            {
                if (_dayNearNode.Evaluate() == NodeStates.SUCCESS)
                {
                    _fleeNode.Evaluate();
                }
                else
                {
                    _wanderNode.Evaluate();
                }
            }
        }
    }
}