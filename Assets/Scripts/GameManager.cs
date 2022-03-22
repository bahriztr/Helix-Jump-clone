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
    private List<GameObject> objectsList = new List<GameObject>();
    public GameObject ground;
    public GameObject ball;
    public int passCount;


    void Start()
    {
        ballTransform = startPos;
        Colors.Instance.ColorsListFunction();
        Colors.Instance.RandomPaintAllMaterials(objectsList);
    }
    
}
