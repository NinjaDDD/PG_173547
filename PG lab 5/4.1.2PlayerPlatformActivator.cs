using UnityEngine;

public class PlayerPlatformActivator : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        MovingPlatformHorizontal platform = hit.collider.GetComponent<MovingPlatformHorizontal>();

        if (platform != null)
        {
            if (Vector3.Dot(hit.normal, Vector3.up) > 0.5f)
            {
                platform.Activate();
            }
        }
    }
}