using System.Collections.Generic;
using GameBrains.Actions;
using GameBrains.Percepts;
using UnityEngine;

namespace GameBrains.Minds
{
	public class SimpleReflexMind : Mind
	{
		[SerializeField] protected float timeTakenCleaning = 50.0f;
        [SerializeField] protected float desiredLevelOfClean = 0.3f;
		public override List<Action> Think(IEnumerable<Percept> percepts)
		{
			var actions = new List<Action>();

			if(ExamineTile(percepts)){
                var clean = new CleanAction {
					timeTakenCleaning = this.timeTakenCleaning,
                    desiredLevelOfClean = this.desiredLevelOfClean,
					completionStatus = CompletionsStates.InProgress,
					timeToLive = moveTimeToLive*1000
                };
                actions.Add(clean);
            }
			// TODO for A1: Implement a Simple Reflex Mind for a cleaning agent.
			
			return actions;
		}

		protected virtual bool ExamineTile(IEnumerable<Percept> percepts) {
			foreach (Percept percept in percepts)
            {
                if (percept is DirtyTilePercept isDirty
                    && isDirty.NeedsCleaning)
                {
                    return true;
                }
            }

            return false;
		}


	}
}