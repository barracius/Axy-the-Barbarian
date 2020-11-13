using General_Scripts;
using UnityEngine;

namespace Rat_Scripts
{
    
    public class fleeNode: Node
    {
        

        //private GameObject player;
        private GameObject rat;
        
        public fleeNode( GameObject rat)
        {
            this.rat = rat;
            //this.player = player;
        }
        
        public override NodeStates Evaluate()
        {
            
            //float distance = Vector3.Distance(rat.transform.position, player.transform.position);
            //if(distance <=5.0f)
            if(RatMainController.sFlee)
            {
                Debug.Log("fleeing");
                return NodeStates.RUNNING;
            }
            else
            {
                
                return NodeStates.SUCCESS;
            }
        }
    }
}