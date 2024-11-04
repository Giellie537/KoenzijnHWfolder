using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maydialoguetrigger : MonoBehaviour
{

    public BoxCollider tiggermay;
    public Triggermay TriggerMay;

void OnTriggerEnter(){
if(TriggerMay.triggered == true){
    Debug.Log("Trigger May dialogue");

}else{
    Debug.Log("nothing happens");

}




}
}