using GameBrains.Visualization;
using UnityEngine;

namespace Testing
{
    [AddComponentMenu("Scripts/Testing/Test BoxCast Checker")]
    public class TestBoxCastChecker : TestCastChecker
    {
        public override string CheckerName => "BoxCast";

        protected override CastChecker CreateInstance()
        {
            return ScriptableObject.CreateInstance<BoxCastChecker>();
        }
    }
}