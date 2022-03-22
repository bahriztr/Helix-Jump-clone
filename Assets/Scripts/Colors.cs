using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using Random = UnityEngine.Random;

public class Colors : Singleton<Colors>
{
    [SerializeField] private GameObject column;
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject obstacle;
    public GameObject ball;
    [SerializeField] private GameObject finishPoint;
    
    private List<List<Color32>> allColorsList = new List<List<Color32>>();
    private List<Color32> colorsOne = new List<Color32>();
    private List<Color32> colorsTwo = new List<Color32>();
    private List<Color32> colorsThree = new List<Color32>();

    private Color32 pinkObstacle = new Color32(245, 187, 242, 96);
    private Color32 blueGround = new Color32(162, 245, 235, 96);
    private Color32 greyColumn = new Color32(245, 238, 211, 96);
    private Color32 darkBlueBall = new Color32(32, 37, 168, 66);
    
    private Color32 orangeObstacle = new Color32(224, 125, 58, 88);
    private Color32 yellowGround = new Color32(250, 199, 103, 98);
    private Color32 purpleColumn = new Color32(44, 31, 148, 58);
    private Color32 purpleBall = new Color32(181, 62, 250, 98);
    
    private Color32 redObstacle = new Color32(163, 36, 36, 64);
    private Color32 blackGround = new Color32(0, 0, 0, 255);
    private Color32 whiteColumn = new Color32(255, 255, 255, 255);
    private Color32 yellowBall = new Color32(240, 238, 101, 94);

    public Color32 ballFirsColor;

    
    public void ColorsListFunction()
    {
        colorsOne.AddRange(new List<Color32>
        {
            greyColumn,
            blueGround,
            pinkObstacle,
            darkBlueBall
        });
        
        colorsTwo.AddRange(new List<Color32>
        {
            purpleColumn,
            yellowGround,
            orangeObstacle,
            purpleBall
        });
        
        colorsThree.AddRange(new List<Color32>
        {
            whiteColumn,
            blackGround,
            redObstacle,
            yellowBall
        });
        
        allColorsList.AddRange(new List<List<Color32>>
        {
            colorsOne,
            colorsTwo,
            colorsThree
        });
    }
    public void RandomPaintAllMaterials(List<GameObject> objs)
    {
        int index = Random.Range(0, allColorsList.Count); // choosing the color
        
        foreach (GameObject obj in objs)
        {
            foreach (Transform child in obj.transform)
            {
               

                if (child.gameObject.CompareTag("Obstacle"))
                {
                    child.GetComponent<Renderer>().material.color = allColorsList[index][2];
                }
                else if(child.gameObject.CompareTag("Platform"))
                {
                    child.GetComponent<Renderer>().material.color = allColorsList[index][1];
                }
                else
                {
                    child.GetComponent<Renderer>().material.color = allColorsList[index][0];
                }
            }
        }
        
        ballFirsColor = allColorsList[index][3];
        ball.GetComponent<Renderer>().material.color = ballFirsColor;
        //tempColor.GetComponent<Renderer>().material.color = ball.GetComponent<Renderer>().material.color;
        //finishPoint.GetComponent<Renderer>().material.color = ball.GetComponent<Renderer>().material.color;

    }
}
