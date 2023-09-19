using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // The player's transform
    public float rotationSpeed = 5.0f;  // Speed of camera rotation
    public float distance = 5.0f;  // Distance from the player
    public float yOffset = 2.0f;  // Vertical offset from the player

    private float currentRotationAngle = 0.0f;

    void LateUpdate()
    {
        if (target == null)
            return;

        // Handle camera rotation using mouse input
        if (Input.GetMouseButton(1))  // Right mouse button
        {
            float horizontal = Input.GetAxis("Mouse X") * rotationSpeed;
            currentRotationAngle += horizontal;
        }

        // Calculate the desired position based on the rotation, distance, and Y offset
        Quaternion rotation = Quaternion.Euler(0, currentRotationAngle, 0);
        Vector3 offset = new Vector3(0, yOffset, -distance);
        Vector3 desiredPosition = target.position + rotation * offset;
        transform.position = desiredPosition;

        // Make the camera look at the player
        transform.LookAt(target.position + Vector3.up * yOffset);
    }
}