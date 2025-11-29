using UnityEngine;

namespace Ghosts
{
    public class RedGhostAiMovement : GhostAiMovement
    {
        protected override void Chase(Vector2 customTarget = default)
        {
            base.Chase(); //Basic chase(new) 
        }
    }
}
