using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadGesture : MonoBehaviour {
    public bool isFacingDown = false;
    public bool isMovingDown = false;

    public float sweepRate = 100.0f;
    private float previousCameraAngle;

    private void Start()
    {
        previousCameraAngle = CameraAngleFromGround();
    }

    private void Update()
    {
        isFacingDown = DetectFacingDown();
        isMovingDown = DetectMovingDown();
    }

    private bool DetectMovingDown()
    {
        float angle = CameraAngleFromGround();
        float deltaAngle = previousCameraAngle - angle;
        float rate = deltaAngle / Time.deltaTime;
        previousCameraAngle = angle;
        return (rate >= sweepRate);
    }

    private bool DetectFacingDown()
    {
        return (CameraAngleFromGround() < 60.0f);
    }

    private float CameraAngleFromGround()
    {
        return Vector3.Angle(Vector3.down, Camera.main.transform.rotation * Vector3.forward);
    }
}
