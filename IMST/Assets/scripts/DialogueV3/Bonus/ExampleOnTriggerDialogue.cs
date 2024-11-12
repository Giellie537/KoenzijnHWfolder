using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleOnTriggerDialogue : MonoBehaviour
{
    public Dialogue dialogue;

    private AudioSource audioSource;
    public AudioClip Papiergeluid;

    public bool collided = true;


    void Start(){
    audioSource = GetComponent<AudioSource>();      
    }

    private void OnTriggerEnter(Collider other)
    {
        if(collided == true){
        FindObjectOfType<DialogueManager2>().EndDialogue();
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        collided = true;
        
        audioSource.PlayOneShot(Papiergeluid);
        
        }
        
    
    }
}
