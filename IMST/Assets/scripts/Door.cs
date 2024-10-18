using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{

Animator animator;
public Text text;
public phone Phone;
public Questclose questclose;


    void Start()
    {
         animator = GetComponent<Animator>();

    }

public void klik1() {
    if (Phone.gepakt == true && questclose.added == true){
        animator.SetTrigger("dooropen");
    }

     

     else {
        text.text = "I cannot leave yet\nI still have to grab something";
        text.enabled = true;

        StartCoroutine(Textweg());
     }
}

     IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        text.enabled = false;
     }



}
