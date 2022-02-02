using GameBrains.Visualization;
using UnityEngine;

namespace Testing
{
    [AddComponentMenu("Scripts/Testing/Test CapsuleCast Visualizer")]
    public class TestCapsuleCastVisualizer : TestCastVisualizer
    {
        protected override CastVisualizer CreateInstance()
        {
            return ScriptableObject.CreateInstance<CapsuleCastVisualizer>();
        }
    }
}