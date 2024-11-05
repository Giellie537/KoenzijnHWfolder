using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleOnTriggerDialogue : MonoBehaviour
{
    public Dialogue dialogue;

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<DialogueManager2>().EndDialogue();
        FindObjectOfType<DialogueManager2>().StartDialogue(dialogue);
    
        //hier je van alles doen... andere scene/audio/animatie etc.
    }
}
