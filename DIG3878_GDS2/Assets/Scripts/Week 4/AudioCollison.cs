using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollison : MonoBehaviour
{
    public AudioClip ding;
    public AudioClip explosion;
    AudioSource audioSource;

    void OnCollisonEnter(Collision col)
    {
        Debug.Log("test1");
        if (col.gameObject.name == "cube")
        {
            Debug.Log("ding");
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(ding);
            
        }
        if (col.gameObject.tag == "Red")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(explosion);
        }
    }
}
