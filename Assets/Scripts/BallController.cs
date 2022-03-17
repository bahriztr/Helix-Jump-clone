using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BallController : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float JumpEnd = 5f;
    [SerializeField] private float JumpDuration = .25f;
    private Rigidbody rb;


    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();    
    }
    void Start()
    {
        //rb.DOJump(new Vector3(0f,JumpEnd,0f), jumpForce, 1, JumpDuration)
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.collider.CompareTag("Platform"))
        {
            Jump();
        }
    }


}
