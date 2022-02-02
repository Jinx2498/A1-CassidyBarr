using GameBrains.Actions;
using GameBrains.Extensions.Attributes;
using UnityEngine;

namespace GameBrains.Actuators.Motion.Movers.UsingVector3.SimpleMovers
{
    public abstract class SimpleMover : Actuator
    {
#pragma warning disable 0414
        // We have multiple versions. This helps tell them apart in the Inspector.
        // ReSharper disable once NotAccessedField.Local
        [ReadOnly] [SerializeField] string version = "UsingVector3";
#pragma warning restore 0414

        #region Actuator Limits
        
        [SerializeField] protected float maximumSpeed = 5f;
        [SerializeField] protected float minimumSpeed = 0.01f;
        
        #endregion Actuator Limits
        
        #region Speed and Direction
        
        [SerializeField] float speed;
        [SerializeField] Vector3 direction;

        public virtual float Speed { get => speed; set => speed = value; }
        public virtual Vector3 Direction { get => direction; set => direction = value; }
        
        #endregion Speed and Direction

        protected abstract void CalculatePhysics(float deltaTime);

        public override void Update() { base.Update(); CalculatePhysics(Time.deltaTime); }
        
        protected override void Act(Action action)
        {
            // TODO for A1 (optional): Differentiate instantaneous versus gradual change
            switch (action)
            {
                case ChangeSpeedAction changeSpeedAction:
                    // TODO for A1: Change the speed using changeSpeedAction.desiredSpeed.
                    // TODO for A1: Set completion status as appropriate.
                    // TODO for A1 (optional): Limit speed change.
                    return;
                case ChangeDirectionAction changeDirectionAction:
                    // TODO for A1: Change the direction using changeDirectionAction.desiredDirection.
                    // TODO for A1: Set completion status as appropriate.
                    // TODO for A1 (optional): Limit direction change.
                    return;
            }
        }
    }
}