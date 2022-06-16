using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/Stay In Radius")]
public class StayInRadiusBehaviour : FlockBehaviour
{
    [SerializeField] private Vector2 _centre;
    [SerializeField] private float _radius = 15f;

    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        Vector2 centreOffset = _centre - (Vector2)agent.transform.position;

        float t = centreOffset.magnitude / _radius;

        if(t < 0.9f)
        {
            return Vector2.zero;
        }

        return centreOffset * t * t; //weight of 0.1f;
    }
}
