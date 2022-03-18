using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Colors : MonoBehaviour
{
    
    [SerializeField] private GameObject column;
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject obstacle;
    [SerializeField] private GameObject ball;
    
    private List<List<Color32>> allColorsList = new List<List<Color32>>();
    private List<Color32> colorsOne = new List<Color32>();
    private List<Color32> colorsTwo = new List<Color32>();
    
    private Color32 pinkObstacle = new Color32(245, 187, 242, 96);
    private Color32 blueGround = new Color32(162, 245, 235, 96);
    private Color32 whiteColumn = new Color32(245, 238, 211, 96);
    private Color32 darkBlueBall = new Color32(32, 37, 168, 66);
    
    private Color32 orangeObstacle = new Color32(224, 125, 58, 88);
    private Color32 yellowGround = new Color32(250, 199, 103, 98);
    private Color32 purpleColumn = new Color32(44, 31, 148, 58);
    private Color32 purpleBall = new Color32(181, 62, 250, 98);

    private void Start()
    {
        colorsOne.AddRange(new List<Color32>
        {
            whiteColumn,
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
        
        allColorsList.AddRange(new List<List<Color32>>
        {
            colorsOne,
            colorsTwo
        });
        
        int index = Random.Range(0, allColorsList.Count);

        column.GetComponent<Renderer>().material.color = allColorsList[index][0];
        ground.GetComponent<Renderer>().material.color = allColorsList[index][1];
        obstacle.GetComponent<Renderer>().material.color = allColorsList[index][2];
        ball.GetComponent<Renderer>().material.color = allColorsList[index][3];
    }
}
