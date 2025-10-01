using UnityEngine;

public class PlayerGizmo : MonoBehaviour
{
    public float radius = 0.7f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
