using GameBrains.Actions;

namespace GameBrains.Actuators
{
    public class CleanActuator : Actuator
    {
        protected override void Act(Action action)
        {
            if (action is CleanAction cleanAction)
            {
                // TODO for A1: Implement cleaning.
                // TODO for A1 (optional): Implement probability of success.
                // TODO for A1 (optional): Implement time delay for cleaning.
            }
        }
    }
}