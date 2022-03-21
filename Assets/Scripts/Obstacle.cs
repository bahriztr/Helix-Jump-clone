using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0f;
        GameManager.Instance.canRotateScreen = false;
    }
}
