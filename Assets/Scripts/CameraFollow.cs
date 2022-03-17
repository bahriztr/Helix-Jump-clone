using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothTime = 0.3f;

    private Vector3 velocity = Vector3.zero;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > BallController.Instance.lastHit)
        {
            Vector3 targetPosition = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }


    }
}
