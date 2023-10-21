using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Variables")]
    public static int objects = 0;
    public bool isTouching;
    public bool isAbsorbed;


    void Start()
    {
        

    }

    void OnCollisionEnter(Collision other){

        if (other.gameObject.tag == "Player" && other.gameObject.tag == "Pickup"){

            isTouching = true;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        // while (isTouching){

        //     isTouching = True

        //     //gameObject.tag == "Pickup"

        //     // OBJECT SCALE DECREASE
        //     // OBJECT gets pulled towards center position of Roomba

        // }

        // if (isAbsorbed){

        //     // ROOMBA SCALE INCREASE  
            
        //     // From child object   CALL ANIMATION + PLAY PARTICLE
        //     // HIDE OBJECT

        //     Debug.Log("Object Absorbed");
        // }
        

    }
}
