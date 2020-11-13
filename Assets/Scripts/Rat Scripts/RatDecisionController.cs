using System;
using System.Collections.Generic;
using General_Scripts;
using Rat_Scripts;
using UnityEngine;

namespace Rat_Scripts
{
    public class RatDecisionController:MonoBehaviour
    {
        

        
        private Node topNode;
        public bool night = false;
        //public GameObject player;
        private void ContructDecisionTree()
        {
            NearNode isPlayerNearNode = new NearNode(gameObject,5.0f);
            NightNode isNight = new NightNode(night);
            AttackNode attackNode = new AttackNode(gameObject);
            fleeNode fleeNode = new fleeNode(gameObject);
            
            Sequence attackSequence = new Sequence(new List<Node> {isPlayerNearNode, isNight, attackNode});
            Sequence runSequece = new Sequence(new List<Node> {isPlayerNearNode, new Inverter(isNight), fleeNode});
            
            topNode = new Selector(new List<Node>(){runSequece,attackSequence});

        }

        private void Start()
        {
            ContructDecisionTree();
        }

        private void Update()
        {
            topNode.Evaluate();
            if(topNode.nodeState == NodeStates.FAILURE)
            {
                Debug.Log("idle");
            }
        }
    }
}