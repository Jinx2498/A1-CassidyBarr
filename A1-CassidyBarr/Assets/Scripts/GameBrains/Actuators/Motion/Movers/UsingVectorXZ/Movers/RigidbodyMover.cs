using UnityEngine;

namespace GameBrains.Actuators.Motion.Movers.UsingVectorXZ.Movers
{
    //[RequireComponent(typeof(Rigidbody))] // needs to attach to parent
    public sealed class RigidbodyMover : Mover
    {
        [SerializeField] bool useForce;

        Rigidbody rb;

        public override void Start()
        {
            base.Start();
            rb = GetComponentInParent<Rigidbody>();
        }

        protected override void CalculatePhysics(float deltaTime)
        {
            // Use average of Vinitial and Vfinal
            // deltaP = (Vinital + Vfinal) / 2 * t
            // Vfinal = Vinitial + A * t
            // deltaP = (Vinitial + Vinitial + A * t) / 2 * t
            // deltaP = (2 * Vinitial + A * t) / 2 * t
            // deltaP = Vinitial * t + A * t * t / 2
            //float halfDeltaTimeSquared = (deltaTime * deltaTime) / 2;
            //VectorXZ positionOffset = (Velocity * deltaTime) + (Acceleration * halfDeltaTimeSquared);
            Velocity += Acceleration * deltaTime;

            if (useForce)
            {
                throw new System.NotImplementedException(
                    "Homework: How can we use rb.AddForce to move properly?");
            }
            else
            {
                // Type cast from VectorXZ to Vector3 sets Y to 0. Good.
                rb.velocity = (Vector3)Velocity;
            }
        }
    }
}