using System;
using UnityEngine;
using DG.Tweening;

    public class DestroyPlatforms : Singleton<DestroyPlatforms>
    {
        private GameObject ball;
        public GameObject ballColor;
        private void Start()
        {
            ball = GameManager.Instance.ball;
            ballColor = Colors.Instance.ball;
        }


        private void Update()
        {
            DestroyPlatform();
        }
        
        public void DestroyPlatform()
        {
            if (ball.transform.position.y < gameObject.transform.position.y - .5f)
            {
                ballColor.GetComponent<Renderer>().material.DOColor(Color.red, 1f);
                gameObject.SetActive(false);
                GameManager.Instance.passCount++;
            }
            if(GameManager.Instance.passCount == 0)
            {
                ballColor.GetComponent<Renderer>().material.color = Colors.Instance.ballFirsColor;
            }
        }
        
    }
    
