using GameBrains.Visualization;
using UnityEngine;

namespace Testing
{
    [AddComponentMenu("Scripts/Testing/Test RayCast Visualizer")]
    public class TestRayCastVisualizer : TestCastVisualizer
    {
        protected override CastVisualizer CreateInstance()
        {
            return ScriptableObject.CreateInstance<RayCastVisualizer>();
        }
    }
}