using UnityEngine;

namespace Ghosts
{
    public class OrangeGhostAiMovement : GhostAiMovement
    {
        // Predicte targer movement(new)
        protected override void Chase(Vector2 customTarget = default)
        {
            float distance = Vector2.Distance(transform.position, chaseModeTarget.transform.position);
            Vector2 target = distance > 8f
                ? (Vector2)chaseModeTarget.transform.position + playerVelocity * 1.5f  
                : scatterModeTarget.transform.position;
            base.Chase(target);
        }
    }
}
