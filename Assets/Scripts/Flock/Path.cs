using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Transform> waypoints;

    public float radius = 2.5f;

    [SerializeField] private Vector3 _gizmoSize = Vector3.one;

    public bool isFill = true;

    private void Start()
    {
        FillWithChildren();
    }

    private void FillWithChildren()
    {
        if (!isFill) return;

        foreach (Transform child in GetComponentInChildren<Transform>())
        {
            if (!waypoints.Contains(child))
            {
                waypoints.Add(child);
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (waypoints == null || waypoints.Count == 0)
        {
            return;
        }

        for (int i = 0; i < waypoints.Count; i++)
        {
            Transform waypoint = waypoints[i];
            if (waypoints == null)
            {
                continue;
            }

            Gizmos.color = Color.cyan;
            Gizmos.DrawCube(waypoint.position, _gizmoSize);
            Gizmos.color = Color.magenta;
            if (i + 1 < waypoints.Count && waypoints[i + 1] != null)
            {
                Gizmos.DrawLine(waypoint.position, waypoints[i + 1].position);
            }
            if (waypoints.Count > 2 && waypoints[0] != null && waypoints[waypoints.Count - 1] != null)
            {
                Gizmos.DrawLine(waypoints[0].position, waypoints[waypoints.Count - 1].position);
            }
        }
    }
}
