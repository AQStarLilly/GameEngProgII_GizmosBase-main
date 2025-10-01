using Unity.VisualScripting;
using UnityEngine;

public class TriggerZoneGizmo : MonoBehaviour
{
    public Vector3 size = Vector3.one;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 1f, 0f, 0.3f);
        Gizmos.DrawCube(transform.position, size);
    }
}
