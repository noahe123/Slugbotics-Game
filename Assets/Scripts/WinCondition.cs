using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ObjectsToCollect.objects == 0){
            Debug.Log("All Objects Collected!!");
        }
        else{
            Debug.Log("Objects Left to Collect:" + ObjectsToCollect.objects);
        }
    }
}
