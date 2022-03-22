using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;
public class HelixManager : MonoBehaviour
{
    [SerializeField] private GameObject[] helixRings;
    private float ySpawn = 0;
    private float ringsDistance = 5f;
    private int numberOfRings = 7;

    private void Start()
    {
        for (int i = 0; i < numberOfRings; i++)
        {
            SpawnRing(Random.Range(0, helixRings.Length));
        }
    }

    public void SpawnRing(int ringIndex)
    {
        GameObject go = Instantiate(helixRings[ringIndex], transform.up * ySpawn, quaternion.identity);
        go.transform.parent = transform;
        ySpawn -= ringsDistance;
    }
}
