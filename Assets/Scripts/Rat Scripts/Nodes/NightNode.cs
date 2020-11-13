using General_Scripts;
using UnityEngine;

namespace Rat_Scripts
{
    public class NightNode : Node
    {
        private bool night;
        

        public NightNode(bool night)
        {
            this.night = night;
        }

        public override NodeStates Evaluate()
        {
            if (night)
            {
                return NodeStates.SUCCESS;
            }
            else
            {
                return NodeStates.FAILURE;
            }
        }
    }
}