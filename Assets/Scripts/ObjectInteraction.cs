using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    // Start is called before the first frame update

    [Header{"Variables"}]
    public bool isTouching
    public bool isAbsorbed

    void Start()
    {
  

    }

    // Update is called once per frame
    void Update()
    {
        while (isTouching){

            // OBJECT SCALE DECREASE

        }

        if (isAbsorbed){

            // ROOMBA SCALE INCREASE
            // HIDE OBJECT

            Debug.Log("Object Absorbed")
        }

    }
}
