using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // ball
    public Vector3 offset;
    public float smoothTime = 0.3f;

    private Vector3 velocity = Vector3.zero;
    void Start()
    {

    }

    void Update()
    {
        if (target.position.y < BallController.Instance.lastHit.y)
        {
            Vector3 targetPosition = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }


        // Vector3 lastHit = BallController.Instance.lastHit;

        // Vector3 targetPosition = new Vector3((int)lastHit.x, (int)lastHit.y, (int)lastHit.z) + offset;
        // transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);


    }
}
