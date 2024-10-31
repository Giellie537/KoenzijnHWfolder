using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
	private AudioSource audioSource;
	public AudioClip Papiergeluid;

 void Start(){
 audioSource = GetComponent<AudioSource>();
        
}
	
    public void TriggerDialogue ()
	{
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
		audioSource.PlayOneShot(Papiergeluid);
	}

}
