using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sarahdialoguetrigger : MonoBehaviour
{

    public Meel meel;
    public melk Melk;
    public Dialogue dialogue;

 public BoxCollider boxcollider;
    private bool triggered = false;

    void OnTriggerEnter(){
        if(meel.meelgepakt == true && Melk.melkgepakt == true){
            
            Debug.Log("trigger sarah dialogue");
            FindObjectOfType<DialogueManager2>().StartDialogue2(dialogue);
            triggered = false;
            
        }
        else{
            Debug.Log("nothing happens");
        }
    }
}
