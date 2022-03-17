using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BallController : Singleton<BallController>
{
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float grav = 15f;
    [SerializeField] private float scaleValue = 1.1f;
    [SerializeField] private float jumpDuration = .5f;
    private Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {

    }

    void Update()
    {
        Vector3 vel = rb.velocity;
        vel.y -= grav * Time.deltaTime;
        rb.velocity = vel;
    }

    public void Jump()
    {
        rb.velocity = new Vector3(0, jumpForce, 0);

    }
    public void ShakeTheBall()
    {
        transform.DOShakeScale(jumpDuration, scaleValue);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Platform"))
        {
            Jump();
            ShakeTheBall();
        }
    }


}
