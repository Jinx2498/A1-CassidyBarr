using GameBrains.Visualization;
using UnityEngine;

namespace Testing
{
    [AddComponentMenu("Scripts/Testing/Test BoxCast Visualizer")]
    public class TestBoxCastVisualizer : TestCastVisualizer
    {
        protected override CastVisualizer CreateInstance()
        {
            return ScriptableObject.CreateInstance<BoxCastVisualizer>();
        }
    }
}