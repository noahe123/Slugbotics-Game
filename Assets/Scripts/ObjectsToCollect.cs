using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsToCollect : MonoBehaviour
{
    RandSpawnObjects randSpawn;

    private void Awake(){
        randSpawn = FindObjectOfType<RandSpawnObjects>().GetComponent<RandSpawnObjects>();
        randSpawn.objects++;
    }

    void Update()
    {
        

    }

}
