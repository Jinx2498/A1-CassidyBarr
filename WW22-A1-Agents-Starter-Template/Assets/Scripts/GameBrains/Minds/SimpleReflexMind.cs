using System.Collections.Generic;
using GameBrains.Actions;
using GameBrains.Percepts;

namespace GameBrains.Minds
{
	public class SimpleReflexMind : Mind
	{
		public override List<Action> Think(IEnumerable<Percept> percepts)
		{
			var actions = new List<Action>();
			
			// TODO for A1: Implement a Simple Reflex Mind for a cleaning agent.
			
			return actions;
		}
	}
}