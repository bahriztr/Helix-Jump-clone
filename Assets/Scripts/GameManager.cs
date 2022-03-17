using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Transform ball;
    [SerializeField] private Transform startPos;
    void Start()
    {
        ball = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
