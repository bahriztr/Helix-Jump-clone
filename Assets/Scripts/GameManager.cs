using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : Singleton<GameManager>
{
    Transform ballTransform;
    [SerializeField] private Transform startPos;
    public bool canRotateScreen = true;
    public GameObject ground;
    public GameObject ball;
    public int passCount;
    public GameObject winPanel;


    void Start()
    {
        ballTransform = startPos;
        // Colors.Instance.ColorsListFunction();
        //Colors.Instance.RandomPaintAllMaterials(objectsList);
    }

    
    
}
