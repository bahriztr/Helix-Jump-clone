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
    public GameObject lastPlatform;

    private void Start()
    {
        numberOfRings = Random.Range(30, 40);
        for (int i = 0; i < numberOfRings; i++)
        {
            SpawnRing(Random.Range(0, helixRings.Length));
            if (i == numberOfRings - 1)
            {   
                // last platform
                GameObject last = Instantiate(lastPlatform, new Vector3(objectsList[i].transform.position.x, objectsList[i].transform.position.y - 5, objectsList[i].transform.position.z), quaternion.identity);
                objectsList.Add(last);
            }
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
