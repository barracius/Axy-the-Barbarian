using General_Scripts;
using UnityEngine;

namespace Rat_Scripts
{
    public class NightNode : Node
    {
        private bool _night;
        

        public NightNode(bool night)
        {
            _night = night;
        }

        public override NodeStates Evaluate()
        {
            return _night ? NodeStates.SUCCESS : NodeStates.FAILURE;
        }
    }
}