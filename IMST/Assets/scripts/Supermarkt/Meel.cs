using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meel : MonoBehaviour
{

    public bool meelgepakt = false;
    public MeshRenderer meshmeel;
    private AudioSource audioSource;
    public AudioClip Papiergeluid;

    void Start(){
        audioSource = GetComponent<AudioSource>();
        
    }

    public void meelpakken(){
        meshmeel.enabled = false;
        meelgepakt = true;
        audioSource.PlayOneShot(Papiergeluid);
    }


}
