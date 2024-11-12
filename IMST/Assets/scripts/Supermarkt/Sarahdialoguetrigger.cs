using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sarahdialoguetrigger : MonoBehaviour
{

    public Meel meel;
    public melk Melk;

 public BoxCollider boxcollider;
    private bool triggered = false;

    void OnTriggerEnter(){
        if(meel.meelgepakt == true && Melk.melkgepakt == true){
            
            Debug.Log("trigger sarah dialogue");
            // triggered = false;
            
        }
        else{
            Debug.Log("nothing happens");
        }
    }
}
