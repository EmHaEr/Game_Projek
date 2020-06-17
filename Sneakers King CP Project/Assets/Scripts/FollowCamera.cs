using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform targetCamera;
    public float smootSpeed = 0.1f;
    public Vector3 cameraOffset;

    void FixedUpdate()
    {
        Vector3 desiredPos = targetCamera.position + cameraOffset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, smootSpeed);

        transform.position = smoothPos;
        transform.LookAt(targetCamera);
    }
}
