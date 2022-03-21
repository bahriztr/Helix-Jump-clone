using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControl : MonoBehaviour
{
    private Vector2 lastPos;
    private float rotationSpeed = 0.2f;

    private void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButton(0) && GameManager.Instance.canRotateScreen)
        {
            Vector2 currPos = Input.mousePosition;

            if(lastPos == Vector2.zero)
            {
                lastPos = currPos;
            }

            float delta = lastPos.x - currPos.x;
            lastPos = currPos;

            transform.Rotate(Vector2.up * delta * rotationSpeed);
        }
        if(Input.GetMouseButtonUp(0) && GameManager.Instance.canRotateScreen)
        {
            lastPos = Vector2.zero;
        }
    }
}
