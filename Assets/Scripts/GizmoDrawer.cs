using System.Collections;
using UnityEngine;

public class GizmoDrawer : MonoBehaviour
{
    public enum GizmoType
    {
        SpawnPoint,
        Waypoint,
        TriggerZone,
        Enemy,
        Player
    }

    [Header("Settings")]
    public GizmoType type;
    public float radius = 0.5f;
    public Vector3 size = Vector3.one;

    private void OnDrawGizmos()
    {
        switch (type)
        {
            case GizmoType.SpawnPoint:
                Gizmos.color = Color.green;
                Gizmos.DrawIcon(transform.position + new Vector3(0f, 1.0f, 0f), "heart.png", true);
                Gizmos.DrawCube(transform.position, Vector3.one * 0.5f);
                break;

            case GizmoType.Waypoint:
                Gizmos.color = Color.blue;
                Gizmos.DrawIcon(transform.position + new Vector3(0f, 1.0f, 0f), "waypoint.png", true);
                Gizmos.DrawWireSphere(transform.position, radius);
                break;

            case GizmoType.Enemy:
                Gizmos.color = Color.red;
                Gizmos.DrawIcon(transform.position + new Vector3(0f, 1.0f, 0f), "skull.png", true);
                Gizmos.DrawWireCube(transform.position, Vector3.one);
                break;
        }         
    }

    private void OnDrawGizmosSelected()
    {
        switch (type)
        {
            case GizmoType.TriggerZone:
                Gizmos.color = new Color(1f, 1f, 0f, 0.3f);
                Gizmos.DrawIcon(transform.position + new Vector3(0f, 1.0f, 0f), "Trigger.png", true);
                Gizmos.DrawCube(transform.position, size);
                break;

            case GizmoType.Player:
                Gizmos.color = Color.cyan;
                Gizmos.DrawIcon(transform.position + new Vector3(0f, 1.0f, 0f), "player.png", true);
                Gizmos.DrawSphere(transform.position, radius);
                break;
        }
    }
}
