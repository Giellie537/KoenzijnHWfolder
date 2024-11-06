using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        FindObjectOfType<DialogueManager2>().EndDialogue();
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

        audioSource.PlayOneShot(Papiergeluid);
        collided = true;
        }
        else{
            Debug.Log("noghting");
        }
    
    }
}
