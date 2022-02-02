using GameBrains.Visualization;
using UnityEngine;

namespace Testing
{
    [AddComponentMenu("Scripts/Testing/Test CapsuleCast Checker")]
    public class TestCapsuleCastChecker : TestCastChecker
    {
        public override string CheckerName => "CapsuleCast";

        protected override CastChecker CreateInstance()
        {
            return ScriptableObject.CreateInstance<CapsuleCastChecker>();
        }
    }
}