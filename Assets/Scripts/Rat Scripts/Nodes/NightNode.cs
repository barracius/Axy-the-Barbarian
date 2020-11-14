using General_Scripts;
using UnityEngine;

namespace Rat_Scripts
{
    public class NightNode : Node
    {
        private Transform _camera;
        private DayNightScript _dayNightScript;
        

        public NightNode(Transform camera)
        {
            _camera = camera;
            _dayNightScript = _camera.GetComponent<DayNightScript>();
        }

        public override NodeStates Evaluate()
        {
            return _dayNightScript.isNight ? NodeStates.SUCCESS : NodeStates.FAILURE;
        }
    }
}