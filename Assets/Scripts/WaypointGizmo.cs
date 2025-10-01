using UnityEngine;

public class WaypointGizmo : MonoBehaviour
{
    public float radius = 0.5f;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
