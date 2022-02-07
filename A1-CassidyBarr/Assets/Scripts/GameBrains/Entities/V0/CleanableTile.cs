using System;
using UnityEngine;
namespace GameBrains.Entities.V0
{

    public class CleanableTile : Entity
    {
        public float getDirtyRate = 10.0f;
        public float dirtyVarience = 1.0f;
        public float currentDirtAmt = 0;
        public float amtDirtToRemove = 0;
        public int maxDirt = 50;

        public Color transparent;

        [SerializeField] protected Material tileColors;

        public void Awake()
        {

        }

        public void Update() 
        {
            float maxDirtInc = getDirtyRate*Time.deltaTime;
            currentDirtAmt += UnityEngine.Random.Range(maxDirtInc*dirtyVarience, maxDirtInc);
            currentDirtAmt = Mathf.Min(maxDirt, currentDirtAmt);    
            TileColor();
            if(amtDirtToRemove != 0f) {
                currentDirtAmt -= amtDirtToRemove;
                amtDirtToRemove = 0f;
            } 
        }

        public void TileColor() {
            if(tileColors != null) {
                float dirty = GetDirtinessState();
                if(dirty == 1f) {
                    tileColors.color = Color.red;
                } else {
                    tileColors.color = Color.clear;
                }
            }
        }

        public float CleanTile(float dirtRemoved) {

            // currentDirtAmt -= dirtRemoved;
            amtDirtToRemove = dirtRemoved;
            return amtDirtToRemove;

        }

        public float GetCurrentDirtAmt() {
            return currentDirtAmt;
        }

        public float GetDirtinessState() {
            return(currentDirtAmt/maxDirt);
        }
    }
}