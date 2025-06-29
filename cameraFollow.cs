using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;      // Character to follow
    public Vector3 offset;        // Distance between camera and character
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target); // Optional: always face the character
    }
}
