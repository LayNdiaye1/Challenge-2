using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;  // Reference to the player car transform
    [SerializeField] Vector3 offset;    // Offset from the target position
    [SerializeField] float smoothSpeed = 5.0f;  // Smoothing factor for camera movement

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Target not set for CameraFollow script.");
            return;
        }

        // Calculate the desired position for the camera
        Vector3 desiredPosition = target.position + offset;

        // Smoothly interpolate between the current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Set the position of the camera
        transform.position = smoothedPosition;

        // Make the camera look at the target
        transform.LookAt(target);
    }
}
