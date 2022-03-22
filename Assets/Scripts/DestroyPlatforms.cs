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
                
                foreach (Transform child in gameObject.transform)
                {
                    if (child.gameObject.CompareTag("Obstacle")|| child.gameObject.CompareTag("Platform"))
                    {
                        child.gameObject.SetActive(false);
                    }
                }
                GameManager.Instance.passCount++;
                UIManager.Instance.score += 25;
                gameObject.GetComponent<DestroyPlatforms>().enabled = false;
            }
            

            //
        }
        
        // void Score()
        // {
        //     if (ball.transform.position.y < gameObject.transform.position.y - .5f)
        //     {
        //         if (!gameObject.transform.GetChild(0).gameObject.activeInHierarchy)
        //         {
        //             GameManager.Instance.passCount++;
        //             UIManager.Instance.score++;
        //         }
        //     }
        // }
    }
    
