using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vis : MonoBehaviour
{

    public bool visgepakt = false;
    public MeshRenderer meshvis;
    private AudioSource audioSource;
    public AudioClip Papiergeluid;

    void Start(){
        audioSource = GetComponent<AudioSource>();
        
    }

    public void meelpakken(){
        meshvis.enabled = false;
        visgepakt = true;
        audioSource.PlayOneShot(Papiergeluid);
    }


}
