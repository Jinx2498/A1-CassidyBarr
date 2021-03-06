using GameBrains.Entities.V0;
using GameBrains.Extensions.MonoBehaviours;
using UnityEngine;

namespace GameBrains.PerformanceMeasures
{
    public class PerformanceMeasure : ExtendedMonoBehaviour
    {
        #region Agent
        
        [SerializeField] protected Agent agent;
        protected virtual Agent Agent => agent;
        
        #endregion Agent
        
        // TODO for A1: What performance criteria are need?
        // TODO for A1 (optional): Replace individual criterion fields with a list to be filled in Awake or Start.
        public float dirtAmountCollected = 0;
        public float timeCleaning = 0;
        
        [SerializeField] float performanceMeasure;
        [SerializeField] int updateInterval; // TODO: Use Regulator?
        float previousTime;

        public override void Awake()
        {
            base.Awake();
            
            // The Agent component should either be attached to the same
            // gameObject as the Actuator component or above it in the hierarchy.
            // This checks the gameObject first and then works its way upward.
            if (agent == null) { agent = GetComponentInParent<Agent>(); }
        }

        public override void Start()
        {
            base.Start();
            
            Agent.PerformanceMeasure = this;
        }

        public override void Update()
        {
            base.Update();
            
            if (Time.time > (previousTime + updateInterval))
            {
                // Record the performance measure of this time interval
                // TODO for A1: Create a performance measure and associated performance criteria.
                if(timeCleaning >= 1) {
                    performanceMeasure = dirtAmountCollected/timeCleaning; // TODO for A1: Replace with weighted formula using criteria
                }
                var message = $"PerformanceMeasure: {performanceMeasure}";
                Agent.DisplayMessage(message);
                
                // Reset, and prepare for the next time interval
                previousTime = Time.time;
            }
        }

        public void SuckDirt(float tileDirt, float time) {
            dirtAmountCollected += tileDirt;
            timeCleaning += time;
        }
    }
}