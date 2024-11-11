using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasta : MonoBehaviour
{

    public bool pastagepakt = false;
    public MeshRenderer meshpasta;
    private AudioSource audioSource;
    public AudioClip Papiergeluid;

    void Start(){
        audioSource = GetComponent<AudioSource>();
        
    }

    public void meelpakken(){
        meshpasta.enabled = false;
        pastagepakt = true;
        audioSource.PlayOneShot(Papiergeluid);
    }


}

