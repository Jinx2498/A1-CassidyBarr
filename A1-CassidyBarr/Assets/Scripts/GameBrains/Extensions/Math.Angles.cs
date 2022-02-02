using UnityEngine;

namespace GameBrains.Extensions
{
    public static partial class Math
    {
        // WrapAngle returns angle in range (-180,180]
        public static float WrapAngle(float angle)
        {
            while (angle <= -180f) { angle += 360f; }
            while (angle > 180f) { angle += -360f; }
            return angle;
        }

        public static float ClampAngle(float angle, float min, float max)
        {
            return Mathf.Clamp(WrapAngle(angle), min, max);
        }
    
    }
}