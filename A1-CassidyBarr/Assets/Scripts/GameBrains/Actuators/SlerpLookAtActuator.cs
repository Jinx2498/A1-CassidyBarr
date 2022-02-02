using GameBrains.Actions;
using UnityEngine;

namespace GameBrains.Actuators
{
    public class SlerpLookAtActuator : Actuator
    {
        [SerializeField] protected float maximumAngularSpeed = 5f; // Represents a limitation of the actuator
        [SerializeField] protected float minimumSatisfactionAngle = 1f; // Represents a limitation of the actuator

        protected override void Act(Action action)
        {
            if (action is ChangeFacingAction changeFacingAction)
            {
                Transform agentTransform = Agent.transform;
                float satisfactionAngle = minimumSatisfactionAngle;
                float angularSpeed =  maximumAngularSpeed;
                
                var angle = Vector3.Angle(agentTransform.forward, changeFacingAction.desiredFacing);

                if (angle < satisfactionAngle)
                {
                    changeFacingAction.completionStatus = Action.CompletionsStates.Complete;
                }
                else
                {
                    agentTransform.rotation 
                        = Quaternion.Slerp(
                            agentTransform.rotation, 
                            Quaternion.LookRotation(changeFacingAction.desiredFacing), 
                            angularSpeed * Time.deltaTime);
                
                    angle = Vector3.Angle(agentTransform.forward, changeFacingAction.desiredFacing);
                
                    if (angle < satisfactionAngle)
                    {
                        changeFacingAction.completionStatus = Action.CompletionsStates.Complete;
                    }
                    else
                    {
                        changeFacingAction.completionStatus = Action.CompletionsStates.InProgress;
                    }
                }
            }
        }
    }
}