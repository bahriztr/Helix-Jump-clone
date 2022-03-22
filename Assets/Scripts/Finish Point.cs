using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0f;
    }
}
