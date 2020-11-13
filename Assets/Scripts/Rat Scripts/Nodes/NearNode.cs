using General_Scripts;
using UnityEngine;

namespace Rat_Scripts
{
    public class NearNode : Node
    {
        
        //private GameObject player;
        private GameObject rat;
        private float threshold;

        public NearNode(GameObject rat, float threshold)
        {
            this.rat = rat;
            this.threshold = threshold;
        }

        public override NodeStates Evaluate()
        {
            //Vector3 offset = rat.transform.position - player.transform.position;
            //float sqrLen = offset.sqrMagnitude;

            // square the distance we compare with
            //if (sqrLen < threshold * threshold)
            if (RatMainController.sFlee)
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