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

    AudioSource myAudioSource;
    Animation myAnimation;

    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        myAnimation = transform.GetChild(0).GetComponent<Animation>();
    }

    void OnCollisionEnter(Collision other){

        if (other.gameObject.tag == "Pickup"){
            
            ObjectsToCollect.objects--;
            other.gameObject.SetActive(false);
            //play child animation
            myAnimation.Play();
            myAudioSource.Play();
            
            
        }
    }



    // Update is called once per frame
    void Update()
    {
        

    }
}
