using General_Scripts;
using UnityEngine;

namespace Rat_Scripts.Nodes
{
    
    public class AttackNode: Node
    {
        private Transform _rat;
        private Transform _axy;

        public AttackNode(Transform rat, Transform axy)
        {
            _rat = rat;
            _axy = axy;
        }

        public override NodeStates Evaluate()
        {
            Debug.Log("rat attacking axy");
            return NodeStates.RUNNING;
        }
    }
}