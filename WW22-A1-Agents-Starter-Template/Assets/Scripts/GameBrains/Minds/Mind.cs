﻿using System.Collections.Generic;
using GameBrains.Actions;
using GameBrains.Entities.V0;
using GameBrains.Extensions.MonoBehaviours;
using GameBrains.Percepts;
using GameBrains.Timers;
using UnityEngine;

namespace GameBrains.Minds
{
	public class Mind : ExtendedMonoBehaviour
	{
		#region Agent
		
		public Agent agent;
		protected virtual Agent Agent => agent;
		
		#endregion Agent

		#region Regulator
		
		[SerializeField] protected float minimumTimeMs;
		[SerializeField] protected float maximumDelayMs;
		[SerializeField] protected RegulatorMode mode;
		[SerializeField] protected RegulatorDistribution regulatorDistribution;
		[SerializeField] protected AnimationCurve distributionCurve 
			= new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
		
		protected Regulator mindUpdateRegulator;
		public Regulator MindUpdateRegulator => mindUpdateRegulator;
		
		#endregion Regulator

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
			
			mindUpdateRegulator ??= new Regulator
			{
				MinimumTimeMs = minimumTimeMs,
				MaximumDelayMs = maximumDelayMs,
				Mode = mode,
				DelayDistribution = regulatorDistribution,
				DistributionCurve = distributionCurve
			};

			Agent.Mind = this;
		}

		// TODO: Make percept history available through a memory component??
		public virtual List<Action> Think(IEnumerable<Percept> percepts)
		{
			return null;
		}
	}
}