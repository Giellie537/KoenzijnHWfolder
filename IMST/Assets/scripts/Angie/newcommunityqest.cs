using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newcommunityqest : MonoBehaviour
{
    
    public bool collided = false;

    public GameObject notif;
    public Text notiftext;

    public GameObject desc;
    public Triggermay TriggerMay;

void OnTriggerEnter(){
    if(!collided && TriggerMay.triggered == true){
                //notification
            notif.SetActive(true);
            notiftext.text = "New community quest";
            desc.SetActive(true);
            StartCoroutine(Textweg());
            collided = true;
    }
    
    }



                    IEnumerator Textweg() {
                    yield return new WaitForSeconds(3);
                    notif.SetActive(false);
                }

}
