using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Variables")]

    AudioSource myAudioSource;
    Animation myAnimation;
    ParticleSystem pickup;
    RandSpawnObjects randSpawn;


    void Start()
    {
        randSpawn = FindObjectOfType<RandSpawnObjects>().GetComponent<RandSpawnObjects>();

        pickup = transform.GetChild(0).GetChild(1).GetComponent<ParticleSystem>();
        myAudioSource = GetComponent<AudioSource>();
        myAnimation = transform.GetChild(0).GetComponent<Animation>();
    }

    void OnCollisionEnter(Collision other){

        if (other.gameObject.tag == "Pickup"){
            
            randSpawn.objects--;
            other.gameObject.SetActive(false);
            //play child animation
            myAnimation.Play();
            myAudioSource.Play();
            pickup.Play();
        }
    }



    // Update is called once per frame
    void Update()
    {
    

    }
}
