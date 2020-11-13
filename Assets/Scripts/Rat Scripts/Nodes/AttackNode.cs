using General_Scripts;
using UnityEngine;

namespace Rat_Scripts
{
    
    public class AttackNode: Node
    {
        
        private GameObject player;
        private GameObject rat;
        
        public AttackNode(GameObject rat)
        {
            this.rat = rat;
            //this.player = player;
        }
        
        public override NodeStates Evaluate()
        {
            
            //float distance = Vector3.Distance(rat.transform.position, player.transform.position);
            //if(distance > 0.2f)
            if(RatMainController.sFlee)
            {
                Debug.Log("chassing");
                return NodeStates.RUNNING;
            }
            else
            {
                
                return NodeStates.SUCCESS;
            }
        }
    }
}