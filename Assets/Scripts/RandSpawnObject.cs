using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSpawnObjects : MonoBehaviour
{
    public GameObject objectToSpawn; // The prefab or object to spawn.
    public int numberOfObjects = 5; // Number of objects to spawn.
    public int objects = 0;


    private void Start()
    {
        SpawnObjects(numberOfObjects);
    }

    void SpawnObjects(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Vector3 randomPosition = GetRandomPosition();
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
        }
    }

    Vector3 GetRandomPosition()
    {
        float xLocation, zLocation;

        do
        {
            xLocation = Random.Range(-30f, 20f);
            zLocation = Random.Range(-30f, 20f);
        } while (IsInAvoidedRange(xLocation, zLocation));

        return new Vector3(xLocation, 0.76f, zLocation);
    }

    bool IsInAvoidedRange(float x, float z)
    {
        return (x >= -2f && x <= 2f) && (z >= -2f && z <= 2f);
    }
}
