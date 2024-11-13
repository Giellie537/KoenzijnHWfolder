using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleOnTriggerDialogue : MonoBehaviour
{
    public Dialogue dialogue;

    private AudioSource audioSource;
    public AudioClip Papiergeluid;

    public bool collided = false;


    void Start(){
    audioSource = GetComponent<AudioSource>();      
    }

    private void OnTriggerEnter(Collider other)
    {
        if(collided == false){
        // FindObjectOfType<DialogueManager2>().EndDialogue();
        FindObjectOfType<DialogueManager2>().StartDialogue2(dialogue);
        collided = true;
        
        audioSource.PlayOneShot(Papiergeluid);
        
        }
        
    
    }
}
