using System;
using UnityEngine;


    public class DestroyPlatforms : MonoBehaviour
    {
        private GameObject ball;

        private void Start()
        {
            ball = GameManager.Instance.ball;
        }


        private void Update()
        {
            DestroyPlatform();
        }
        
        public void DestroyPlatform()
        {
            if (ball.transform.position.y < gameObject.transform.position.y)
            {
                Destroy(gameObject, .2f);
                GameManager.Instance.passCount++;
            }
        }
    }
    
