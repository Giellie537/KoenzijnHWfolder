using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heysounds : MonoBehaviour
{
    public bool said = false;
    AudioSource audioSource;

    public AudioClip hey;

    void start() {
        audioSource = GetComponent<AudioSource>();
    }
    public void saystuff() {
       audioSource.PlayOneShot(hey);
       said = true;
    }
}
