using GameBrains.Visualization;
using UnityEngine;

namespace Testing
{
    [AddComponentMenu("Scripts/Testing/Test LineCast Visualizer")]
    public class TestLineCastVisualizer : TestCastVisualizer
    {
        protected override CastVisualizer CreateInstance()
        {
            return ScriptableObject.CreateInstance<LineCastVisualizer>();
        }
    }
}