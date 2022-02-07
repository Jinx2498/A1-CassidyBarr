using GameBrains.Entities.V0;

namespace GameBrains.Percepts
{
    // TODO for A1: Add a new Percept class for dirty tiles. Use TargetEntityPercept as a starting point.
    public class TargetEntityPercept : Percept
    {
        public TargetEntity targetEntity;

    }

    public class DirtyTilePercept : Percept
    {
        public TargetEntity dirtyTile;

        public float DirtAmt{ get; set; }
        public float DirtinessLevel{ get; set; }
        public bool NeedsCleaning{ get; set; }

    }
}