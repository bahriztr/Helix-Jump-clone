using System.Collections;
using System.Collections.Generic;
using Cinemachine.Utility;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ball; // ball
    public Vector3 offset;
    public float smoothTime = 0.3f;

    public float positionOffset;
    private Vector3 velocity;
    void Start()
    {
        offset = transform.position - ball.position;
    }

    void FixedUpdate()
    {
        
        Vector3 targetPos = ball.position + offset;

        
        if (ball.position.y < transform.position.y + positionOffset)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
        }
    }
}
