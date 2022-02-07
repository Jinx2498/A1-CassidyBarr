using GameBrains.Actions;
using GameBrains.Entities.V0;
using GameBrains.Entities;
using UnityEngine;

namespace GameBrains.Actuators
{
    public class CleanActuator : Actuator
    {
        [SerializeField] protected RaycastHit ishit;
        [SerializeField] protected float dirtRemovalPerSecond = 10.0f;
        protected float timeTaken = 0;

        protected bool collide = false;

        // TODO for A1: Implement cleaning.
        // TODO for A1 (optional): Implement probability of success.
        // TODO for A1 (optional): Implement time delay for cleaning.
        public void Update() {
            timeTaken += 1;
        }

        void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.name == "DirtyTile"){
                collide = true;
            }
        }
        
        protected override void Act(Action action)
        {
            // if(TileDetected()){
                if (action is CleanAction cleanAction)
                {
                    if(collide == true) {
                        var tile = gameObject.GetComponent<CleanableTile>();
                        var dirtinessBeforeCleaning = tile.GetDirtinessState();
                        var amtCleaned = CleanTile(tile);
                        var dirtinessAfterCleaning = tile.GetDirtinessState();
                    }
                }
            // }
        }


        public float CleanTile(CleanableTile tile) {

            var dirtSucked = tile.CleanTile(dirtRemovalPerSecond);
            Agent.PerformanceMeasure.SuckDirt(dirtSucked, timeTaken);
            return dirtSucked;
        }
    }

    // public bool TileDetected() {
    //     Transform aTransform = Agent.transform;
    //     var aPosition = aTransform.position + new Vector3(0f, 10f, 0f);
    //     var gotHit = Physics.Raycast(aPosition, aTransform.TransformDirection(Vector3.down), out ishit, Mathf.Infinity);
    //     return gotHit;
    // }
}