using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Image buttonimage;
    public Button buttonbutton;
    public GameObject TextParent;
    public Text Questtext;
    public Text Fromtext;
    public Text Desctext;

    public GameObject notif;
    public Text notiftext;


    void OnTriggerEnter() {
        //doe cijfertje bij de counter
        QuestsuestSystem.instance.addquest();
        
        //make button visible
        buttonimage.enabled = true;
        buttonbutton.enabled = true;
        TextParent.SetActive(true);

        //change quest description etc
        Questtext.text = "Groceries";
        Fromtext.text = "Angie";
        Desctext.text = "Get groceries for Angie";

        //notification
        notif.SetActive(true);
        notiftext.text = "Quest added";
        StartCoroutine(Textweg());
    }

        IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        notif.SetActive(false);
     }
}