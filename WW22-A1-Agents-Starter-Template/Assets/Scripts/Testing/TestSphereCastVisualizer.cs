using GameBrains.Visualization;
using UnityEngine;

namespace Testing
{
    [AddComponentMenu("Scripts/Testing/Test SphereCast Visualizer")]
    public class TestSphereCastVisualizer : TestCastVisualizer
    {
        protected override CastVisualizer CreateInstance()
        {
            return ScriptableObject.CreateInstance<SphereCastVisualizer>();
        }
    }
}