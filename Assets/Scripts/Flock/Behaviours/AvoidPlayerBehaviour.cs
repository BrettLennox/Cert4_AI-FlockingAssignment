using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/AvoidPlayer")]
public class AvoidPlayerBehaviour : FlockBehaviour
{

    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        Vector2 avoidanceMove = Vector2.zero;

        Vector3 playerPos = PlayerController.playerPos;
        Vector3 agentPos = agent.transform.position;
        float distance = Vector3.Distance(playerPos, agentPos);
        if (distance <= 20f)
        {
            avoidanceMove = agentPos - playerPos; //math could be wrong
        }

        return avoidanceMove;
    }
}
