using UnityEngine;

namespace Ghosts
{
    //It will predict the direction 4 grids in advance, and at the same time, it will also predict the velocity vector.(new)
    public class PinkGhostAiMovement : GhostAiMovement
    {
        protected override void Chase(Vector2 customTarget = default)
        {
            Vector2 predictPos = (Vector2)chaseModeTarget.transform.position + playerVelocity.normalized * 4f;
            base.Chase(predictPos);
        }

    }
}
