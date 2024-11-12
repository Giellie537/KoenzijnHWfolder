using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundscript : MonoBehaviour
{

AudioSource audioSource;

public AudioClip talk;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(talk);
    }

    // Update is called once per frame
}
