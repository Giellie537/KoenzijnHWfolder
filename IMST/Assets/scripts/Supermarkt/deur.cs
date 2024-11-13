using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deur : MonoBehaviour
{

Animator animator;
private AudioSource audioSource;
public AudioClip Papiergeluid;

public void Start(){
    animator = GetComponent<Animator>();
    audioSource = GetComponent<AudioSource>();
}

public void openen(){
            animator.SetTrigger("open");
            audioSource.PlayOneShot(Papiergeluid);
}

}
