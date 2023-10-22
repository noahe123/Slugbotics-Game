using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    public bool gameWon = false;
    // Start is called before the first frame update
    void Start()
    {
        //tells the controller the max timer is 15 seconds
        GameObject.Find("Sofa").GetComponent<MicrogameJamController>().SetMaxTimer(15);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameObject.Find("Sofa").GetComponent<MicrogameJamController>().GetTimer());

        if(ObjectsToCollect.objects == 0){
            if(gameWon == false){
                gameWon = true;
                //tells the controller that the game state is Won
                GameObject.Find("Sofa").GetComponent<MicrogameJamController>().WinGame();
                
                Debug.Log("All Objects Collected!!");
            }   
        }else{
            Debug.Log("Objects Left to Collect:" + ObjectsToCollect.objects);
            
            //calls for the current time and auto checks if <= 0, if so it calls LoseGame()
            GameObject.Find("Sofa").GetComponent<MicrogameJamController>().GetTimer();
            

        }
    }
}
