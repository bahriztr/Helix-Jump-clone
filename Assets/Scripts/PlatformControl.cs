using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControl : MonoBehaviour
{
    private Vector2 lastPos;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector2 currPos = Input.mousePosition;

            if(lastPos == Vector2.zero)
            {
                lastPos = currPos;
            }

            float delta = lastPos.x - currPos.x;
            lastPos = currPos;

            transform.Rotate(Vector2.up * delta);
        }
        if(Input.GetMouseButtonUp(0))
        {
            lastPos = Vector2.zero;
        }
    }
}