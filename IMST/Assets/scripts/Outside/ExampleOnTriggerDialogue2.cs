using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleOnTriggerDialogue2 : MonoBehaviour
{
    public Dialogue dialogue;

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<sarahsafed>().EndDialogue();
        FindObjectOfType<sarahsafed>().StartDialogue(dialogue);

        //hier je van alles doen... andere scene/audio/animatie etc.
    }
}
