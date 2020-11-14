
using General_Scripts;
using UnityEngine;

namespace Rat_Scripts.Nodes
{
    public class WanderNode : Node
    {
        private int _randomTemp;
        private Transform _rat;
        private RatMainController _ratMainController;

        public WanderNode(Transform rat)
        {
            _rat = rat;
            _ratMainController = _rat.GetComponent<RatMainController>();
        }

        private void Wander()
        {
            _randomTemp = Random.Range(0, 4);
            switch (_randomTemp)
            {
                case 0:
                    _rat.Translate(_ratMainController.wanderingMovementSpeed * Time.deltaTime * Vector2.left);
                    break;
                case 1:
                    _rat.Translate(_ratMainController.wanderingMovementSpeed * Time.deltaTime * Vector2.right);
                    break;
                case 2:
                    _rat.Translate(_ratMainController.wanderingMovementSpeed * Time.deltaTime * Vector2.up);
                    break;
                case 3:
                    _rat.Translate(_ratMainController.wanderingMovementSpeed * Time.deltaTime * Vector2.down); 
                    break;
            }
        }

        public override NodeStates Evaluate()
        {
            Wander();
            return NodeStates.RUNNING;
        }
    }
}
