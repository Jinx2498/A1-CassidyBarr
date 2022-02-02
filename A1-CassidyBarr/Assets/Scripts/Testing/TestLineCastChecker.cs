using GameBrains.Visualization;
using UnityEngine;

namespace Testing
{
    [AddComponentMenu("Scripts/Testing/Test LineCast Checker")]
    public class TestLineCastChecker : TestCastChecker
    {
        public override string CheckerName => "LineCast";

        protected override CastChecker CreateInstance()
        {
            return ScriptableObject.CreateInstance<LineCastChecker>();
        }
    }
}