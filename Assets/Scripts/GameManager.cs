using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private GameObject columnPrefab;
    Transform ballTransform;
    private Vector3 columnVector = new Vector3(0, 0, 0);
    [SerializeField] private Transform startPos;
    public bool canRotateScreen = true;
    private List<GameObject> objectsList = new List<GameObject>();
    public GameObject ground;
    public GameObject ball;
    public int passCount;


    void Start()
    {
        ballTransform = startPos;
        InstantiateColumns();
        Colors.Instance.ColorsListFunction();
        Colors.Instance.RandomPaintAllMaterials(objectsList);
    }


    public void InstantiateColumns()
    {
        for(int i = 1; i <= Random.Range(30, 40); i++)
        {
           GameObject go = Instantiate(columnPrefab, new Vector3(columnVector.x, columnVector.y - 6 * i, columnVector.z), quaternion.identity);
           objectsList.Add(go);
        }
    }

    
}
