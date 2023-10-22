using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    public bool gameWon = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Microgame Jam Controller").GetComponent<MicrogameJamController>().SetMaxTimer(15);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(ObjectsToCollect.objects == 0){
            if(gameWon == false){
                gameWon = true;
                Debug.Log("All Objects Collected!!");
            }   
        }else{
            Debug.Log("Objects Left to Collect:" + ObjectsToCollect.objects);
        }
    }
}
