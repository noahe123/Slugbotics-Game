using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSpawnObjects : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(Random.Range(-20,20),0.76f,Random.Range(-20,20));
    }

}


