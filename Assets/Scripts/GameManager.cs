using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject columnPrefab;
    Transform ball;
    private Vector3 columnVector = new Vector3(0, 0, 0);
    [SerializeField] private Transform startPos;
    void Start()
    {
        ball = startPos;
        InstantiateColumns();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void InstantiateColumns()
    {
        for(int i = 1; i <= Random.Range(30, 40); i++)
        {
            Instantiate(columnPrefab, new Vector3(columnVector.x, columnVector.y - 6 * i, columnVector.z), quaternion.identity);
        }
    }
}
