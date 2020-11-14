using General_Scripts;
using UnityEngine;

namespace Rat_Scripts.Nodes
{
    
    public class AttackNode: Node
    {
        private Transform _rat;
        private RatMainController _ratMainController;

        public AttackNode(Transform rat, Transform axy)
        {
            _rat = rat;
            _ratMainController = _rat.GetComponent<RatMainController>();
        }

        public override NodeStates Evaluate()
        {
            Attack();
            return NodeStates.RUNNING;
        }
        
        private void Attack()
        {
            if (_ratMainController.axy.position.x < _rat.position.x)
            {
                _rat.Translate(_ratMainController.fleeingMovementSpeed * Time.deltaTime * Vector2.left);
            }
            else
            {
                _rat.Translate(_ratMainController.fleeingMovementSpeed * Time.deltaTime * Vector2.right);
            }

            if (_ratMainController.axy.position.y < _rat.position.y)
            {
            
                _rat.Translate(_ratMainController.fleeingMovementSpeed * Time.deltaTime * Vector2.down);
            }
            else 
            {
                _rat.Translate(_ratMainController.fleeingMovementSpeed * Time.deltaTime * Vector2.up); 
            }
        }
    }
}