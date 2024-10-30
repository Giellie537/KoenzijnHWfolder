using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sarahdialoguetrigger : MonoBehaviour
{

    public Meel meel;
    public melk Melk;
    private bool triggered = false;

    void OnTriggerEnter(){
        if(meel.meelgepakt == true && Melk.melkgepakt == true && triggered == false){
            Debug.Log("trigger sarah dialogue");
            triggered = true;
        }
        else{
            Debug.Log("nothing happens");
        }
    }
}
