using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maydialoguetrigger : MonoBehaviour
{

    public BoxCollider tiggermay;
    public Triggermay TriggerMay;
    private bool triggered = false;


void OnTriggerEnter(){
if(TriggerMay.triggered == true){
    Debug.Log("Trigger May dialogue");

    triggered = false;

}else{
    Debug.Log("nothing happens");

}




}
}