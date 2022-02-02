using GameBrains.Entities.V0;
using GameBrains.Percepts;
using UnityEngine;

namespace GameBrains.Sensors
{
    // TODO for A1: Add a new sensor class for detecting dirty tiles. Use TargetEntitySensor as a starting point.
    public class TargetEntitySensor : Sensor
    {
        [SerializeField] float sensorRange = 20.0f;
        public TargetEntity targetEntity;

        public override Percept Sense()
        {
            if (targetEntity != null)
            {
                var targetEntityPercept = new TargetEntityPercept();
                var agentPosition = Agent.transform.position;

                var targetDistance = Vector3.Distance(agentPosition, targetEntity.transform.position);

                // Are we within range?
                if (targetDistance <= sensorRange && targetEntity != null)
                {
                    targetEntityPercept.targetEntity = targetEntity;
                    return targetEntityPercept;
                }
            }

            return null;
        }
    }
}