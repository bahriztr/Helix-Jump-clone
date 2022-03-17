using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;
    private Rigidbody rb;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();    
    }
    void Start()
    {
        
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
