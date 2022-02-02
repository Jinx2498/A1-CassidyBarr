using GameBrains.Actions;
using GameBrains.Actuators.Motion.Movers.UsingVectorXZ.SimpleMovers;
using GameBrains.Extensions.Attributes;
using GameBrains.Extensions.Vectors;
using UnityEngine;

namespace GameBrains.Actuators.Motion.Movers.UsingVectorXZ.Movers
{
    [HidePropertiesInInspector("speed", "direction")] // Hide so we don't try to set them
    public abstract class Mover : SimpleMover
    {
        [SerializeField] VectorXZ velocity;
        [SerializeField] VectorXZ acceleration;

        public virtual VectorXZ Velocity
        {
            get => velocity;
            set => velocity = value;
        }

        public virtual VectorXZ Acceleration
        {
            get => acceleration;
            set => acceleration = value;
        }

        public override float Speed
        {
            get => velocity.magnitude;
            set => velocity = velocity.normalized * value;
        }

        public override VectorXZ Direction
        {
            get => velocity.normalized;
            set => velocity = velocity.magnitude * value;
        }

        public override void Update() { } // We'll use fixed update instead

        public override void FixedUpdate() { base.FixedUpdate(); CalculatePhysics(Time.fixedDeltaTime); }
        
        protected override void Act(Action action)
        {
            base.Act(action);
            
            // TODO for A1 (optional): Differentiate instantaneous versus gradual change
            switch (action)
            {
                case ChangeVelocityAction changeVelocityAction:
                    // TODO for A1: Change the velocity. Set completion status.
                    // TODO for A1 (optional): Limit velocity change.
                    return;
                case ChangeAccelerationAction changeAccelerationAction:
                    // TODO for A1: Change the acceleration. Set completion status.
                    // TODO for A1 (optional): Limit acceleration change.
                    return;
            }
        }
    }
}