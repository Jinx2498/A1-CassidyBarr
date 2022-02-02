using GameBrains.Visualization;
using UnityEngine;

namespace Testing
{
    [AddComponentMenu("Scripts/Testing/Test RayCast Checker")]
    public class TestRayCastChecker : TestCastChecker
    {
        public override string CheckerName => "RayCast";

        protected override CastChecker CreateInstance()
        {
            return ScriptableObject.CreateInstance<RayCastChecker>();
        }
    }
}