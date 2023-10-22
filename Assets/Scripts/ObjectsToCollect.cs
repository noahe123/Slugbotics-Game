using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsToCollect : MonoBehaviour
{

    private void Awake(){

        FindObjectOfType<RandSpawnObjects>().GetComponent<RandSpawnObjects>().objects++;
    }

    void Update(){
        

    }

}
