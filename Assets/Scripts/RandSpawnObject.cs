using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSpawnObjects : MonoBehaviour
{

    public Vector3 myVec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(Random.Range(-70,70),0.76f,Random.Range(-70,70));
        
    }
}


