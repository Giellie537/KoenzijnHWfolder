using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ei : MonoBehaviour
{

    public bool eigepakt = false;
    public MeshRenderer meshei;
    private AudioSource audioSource;
    public AudioClip Papiergeluid;

    void Start(){
        audioSource = GetComponent<AudioSource>();
        
    }

    public void meelpakken(){
        meshei.enabled = false;
        eigepakt = true;
        audioSource.PlayOneShot(Papiergeluid);
    }


}
