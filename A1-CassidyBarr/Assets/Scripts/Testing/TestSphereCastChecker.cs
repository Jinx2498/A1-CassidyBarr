using GameBrains.Visualization;
using UnityEngine;

namespace Testing
{
    [AddComponentMenu("Scripts/Testing/Test SphereCast Checker")]
    public class TestSphereCastChecker : TestCastChecker
    {
        public override string CheckerName => "SphereCast";

        protected override CastChecker CreateInstance()
        {
            return ScriptableObject.CreateInstance<SphereCastChecker>();
        }
    }
}