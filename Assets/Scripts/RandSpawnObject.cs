using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSpawnObjects : MonoBehaviour
{


    // Start is called before the first frame update
    void Update()
    {
        newSpawn(checkX(), checkZ());
        
    }

    void  newSpawn(float xLocation, float zLocation){
        
        gameObject.transform.position = new Vector3(xLocation, 0.76f, zLocation);
    }

    float checkX(){
        
        float xLoc = Random.Range(-20,20);

        //need to avoid the ranges of -2 and -2 on the x and z axis
        if(xLoc >= -2 && xLoc <= 2){
            checkX();
        }


        Debug.Log(xLoc);
        return xLoc;
    }

    float checkZ(){
        float zLoc = Random.Range(-20,20);

        //need to avoid the ranges of -2 and -2 on the x and z axis
        if(zLoc >= -2 && zLoc <= 2){
            checkZ();
        }

        Debug.Log(zLoc);
        return zLoc;
    }

}


