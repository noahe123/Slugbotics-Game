using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    public GameObject objUI;
    public bool gameWon = false;
    RandSpawnObjects randSpawn;


    // Start is called before the first frame update
    void Start()
    {
        randSpawn = FindObjectOfType<RandSpawnObjects>().GetComponent<RandSpawnObjects>();

        //tells the controller the max timer is 15 seconds
        GameObject.Find("Sofa").GetComponent<MicrogameJamController>().SetMaxTimer(15);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameObject.Find("Sofa").GetComponent<MicrogameJamController>().GetTimer());

        objUI = GameObject.Find("ScoreKeeper");

        objUI.GetComponent<Text>().text = "Objects Remaining: " + randSpawn.objects.ToString();


        if(randSpawn.objects == 0){
            if(gameWon == false){
                gameWon = true;
                //tells the controller that the game state is Won
                GameObject.Find("Sofa").GetComponent<MicrogameJamController>().WinGame();
                
                Debug.Log("All Objects Collected!!");
            }   
        }else{
            Debug.Log("Objects Left to Collect:" + randSpawn.objects);
            
            //calls for the current time and auto checks if <= 0, if so it calls LoseGame()
            GameObject.Find("Sofa").GetComponent<MicrogameJamController>().GetTimer();
            

        }
    }
}
