using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
	

 void Start(){

        
}
	
    public void TriggerDialogue ()
	{
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}
	  public void TriggerDialogueGerard ()
	{
        FindObjectOfType<Gerarddia>().StartDialogue(dialogue);
	}
	  public void TriggerDialogueMay ()
	{
        FindObjectOfType<Maydia>().StartDialogue(dialogue);
	}
	  public void TriggerDialogueTim ()
	{
        FindObjectOfType<Timdia>().StartDialogue(dialogue);
	}
	  public void TriggerDialogueSarah ()
	{
        FindObjectOfType<Sarahdia>().StartDialogue(dialogue);
	}
	  public void TriggerDialogueAngie()
	{
        FindObjectOfType<Angiedia>().StartDialogue(dialogue);
	}
	  public void TriggerDialogueAngiesquest()
	{
        FindObjectOfType<Angiesquest>().StartDialogue(dialogue);
	}
		  public void TriggerDialoguesarahsafed()
	{
        FindObjectOfType<sarahsafed>().StartDialogue(dialogue);
	}
	
		public void TriggerDialogueRandomdia()
	{
        FindObjectOfType<Randomdia>().StartDialogue(dialogue);
	}
	public void TriggerDialogueSarahHelp()
	{
        FindObjectOfType<SarahHelp>().StartDialogue(dialogue);
	}

public void TriggerDialogueangiereturn()
	{
        FindObjectOfType<angiererun>().StartDialogue(dialogue);
	}
	public void TriggerDialoguemayreturn()
	{
        FindObjectOfType<mayreturn>().StartDialogue(dialogue);
	}
}
