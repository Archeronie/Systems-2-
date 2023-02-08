using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{
    public AudioClip myClip;
    AudioSource audioSource;

    void OnTriggerEnter(Collider col)
    {
        audioSource = GetComponent<AudioSource>();
        if (col.gameObject.name == "Dinger")
        {
            audioSource.PlayOneShot(myClip);
        }
    }
}
