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

    public Vector3 lastHit;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        lastHit = transform.position;
        //gameObject.GetComponent<Renderer>().material.DOColor(Color.red, .1f).Pause();

    }

    void Update()
    {
        Vector3 vel = rb.velocity;
        vel.y -= grav * Time.deltaTime;
        rb.velocity = vel;

        if (GameManager.Instance.passCount >= 1)
        {
            //gameObject.GetComponent<Renderer>().material.DOPlay();
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
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
            //ShakeTheBall();
            
            if (lastHit.y > transform.position.y)
            {
                lastHit = transform.position;
            }

            
        }

        if (other.collider.CompareTag("Platform") || other.collider.CompareTag("Obstacle"))
        {
            if (GameManager.Instance.passCount >= 3)
            {
                foreach (Transform child in other.gameObject.transform.parent.transform)
                {
                    if (child.gameObject.CompareTag("Obstacle")  || child.gameObject.CompareTag("Platform") )
                    {
                        child.gameObject.SetActive(false);
                    }
                }
                GameManager.Instance.passCount = 0;
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
                
     
            }
            else
            {
                GameManager.Instance.passCount = 0;
                gameObject.transform.GetChild(0).gameObject.SetActive(false);

            }
        }
    }


}
