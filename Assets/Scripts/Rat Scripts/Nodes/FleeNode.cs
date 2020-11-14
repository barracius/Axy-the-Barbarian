using General_Scripts;
using UnityEngine;

namespace Rat_Scripts.Nodes
{
    
    public class FleeNode: Node
    {

        private RatMainController _ratMainController;
        private Transform _rat;

        public FleeNode( Transform rat)
        {
            _rat = rat;
            _ratMainController = _rat.GetComponent<RatMainController>();
        }
        
        public override NodeStates Evaluate()
        {
            Flee();
            return NodeStates.RUNNING;
        }
        
        private void Flee()
        {
            if (_ratMainController.axy.position.x < _rat.position.x)
            {
                _rat.Translate(_ratMainController.fleeingMovementSpeed * Time.deltaTime * Vector2.right);
            }
            else
            {
                _rat.Translate(_ratMainController.fleeingMovementSpeed * Time.deltaTime * Vector2.left);
            }

            if (_ratMainController.axy.position.y < _rat.position.y)
            {
            
                _rat.Translate(_ratMainController.fleeingMovementSpeed * Time.deltaTime * Vector2.up);
            }
            else 
            {
                _rat.Translate(_ratMainController.fleeingMovementSpeed * Time.deltaTime * Vector2.down); 
            }
        }
    }
}