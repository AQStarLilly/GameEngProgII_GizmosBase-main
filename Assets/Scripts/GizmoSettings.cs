using Unity.VisualScripting;
using UnityEngine;

[ExecuteAlways]
public class GizmoSettings : MonoBehaviour
{
    public static GizmoSettings Instance;

    [Header("Global Toggles")]
    public bool showSpawnPoints = true;
    public bool showWaypoints = true;
    public bool showTriggerZones = true;
    public bool showEnemies = true;
    public bool showPlayers = true;

    private void OnEnable()
    {
        Instance = this;
    }

    private void OnDisable()
    {
        if (Instance == this)
            Instance = null;
    }

    public static bool IsEnabled(GizmoDrawer.GizmoType type)
    {
        if (Instance == null) return true;
        switch (type)
        {
            case GizmoDrawer.GizmoType.SpawnPoint: return Instance.showSpawnPoints;
            case GizmoDrawer.GizmoType.Waypoint: return Instance.showWaypoints;
            case GizmoDrawer.GizmoType.TriggerZone: return Instance.showTriggerZones;
            case GizmoDrawer.GizmoType.Enemy: return Instance.showEnemies;
            case GizmoDrawer.GizmoType.Player: return Instance.showPlayers;
        }
        return true;
    }
}
