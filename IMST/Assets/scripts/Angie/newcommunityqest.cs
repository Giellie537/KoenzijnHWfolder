using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newcommunityqest : MonoBehaviour
{
    
    public bool collided = false;

    public GameObject notif;
    public Text notiftext;

    public GameObject roof;

void OnTriggerEnter(){
    if(!collided){
                //notification
            notif.SetActive(true);
            notiftext.text = "New community quest";
            roof.SetActive(true);
            StartCoroutine(Textweg());
            collided = true;
    }
    }

                    IEnumerator Textweg() {
                    yield return new WaitForSeconds(3);
                    notif.SetActive(false);
                }

}
