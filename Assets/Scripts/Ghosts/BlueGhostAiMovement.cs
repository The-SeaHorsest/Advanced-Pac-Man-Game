using UnityEngine;

namespace Ghosts
{
    public class BlueGhostAiMovement : GhostAiMovement
    {
        public GameObject redGhost;

        protected override void Chase(Vector2 customTarget = default)
        {
            Vector2 redPos = redGhost.transform.position;
            Vector2 playerPos = chaseModeTarget.transform.position;
            Vector2 direction = (playerPos - redPos) * 2f;
            Vector2 inkyTarget = playerPos + direction + playerVelocity * 1.5f;  //Enhanced Inky Algorithm(new)
            base.Chase(inkyTarget);
        }
    }
}
