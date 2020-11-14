using General_Scripts;
using UnityEngine;

namespace Rat_Scripts
{
    public class NearNode : Node
    {
        private Transform _rat;
        private Transform _axy;
        private float _threshold;

        public NearNode(Transform rat, Transform axy, float threshold)
        {
            _rat = rat;
            _axy = axy;
            _threshold = threshold;
        }

        public override NodeStates Evaluate()
        {
            float distance = Vector2.Distance(_rat.position, _axy.position);
            return distance <= _threshold ? NodeStates.SUCCESS : NodeStates.FAILURE;
        }
    }
}