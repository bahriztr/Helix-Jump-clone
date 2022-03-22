using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;
public class HelixManager : Singleton<HelixManager>
{
    [SerializeField] private GameObject[] helixRings;
    private float ySpawn = 0;
    private float ringsDistance = 5f;
    private int numberOfRings;
    public List<GameObject> objectsList = new List<GameObject>();


    private void Start()
    {
        numberOfRings = Random.Range(30, 40);
        for (int i = 0; i < numberOfRings; i++)
        {
            SpawnRing(Random.Range(0, helixRings.Length));
        }
        Colors.Instance.ColorsListFunction();
        Colors.Instance.RandomPaintAllMaterials(objectsList);
    }

    public void SpawnRing(int ringIndex)
    {
        GameObject go = Instantiate(helixRings[ringIndex], transform.up * ySpawn, quaternion.identity);
        go.transform.parent = transform;
        ySpawn -= ringsDistance;
        
        objectsList.Add(go);
        
        
    }
}
