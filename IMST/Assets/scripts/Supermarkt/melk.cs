using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melk : MonoBehaviour
{
    public bool melkgepakt = false;
    public MeshRenderer meshmelk;
        private AudioSource audioSource;
    public AudioClip Papiergeluid;

     void Start(){
        audioSource = GetComponent<AudioSource>();
        
    }

        public void melkpakken(){
        meshmelk.enabled = false;
        melkgepakt = true;
                audioSource.PlayOneShot(Papiergeluid);
    }
}
