using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class negcounterscript : MonoBehaviour
{

public static float negtotal = 0;
public Text text;
public bool textaan = false;

public static void addnegative(float amount){
    negtotal += amount;
}

    // Update is called once per frame
    void Update()
    {
        if(negtotal == 3 && textaan == false){
            StartCoroutine(leave());
            textaan = true;
        }
    }

        IEnumerator leave() {
            yield return new WaitForSeconds(5);
            text.text = "I don't think I am welcome here\nI should go home";
            text.enabled = true;
            Debug.Log("ikdoehetjeej");
            StartCoroutine(leavetext());

     }
        IEnumerator leavetext() {
            yield return new WaitForSeconds(3);
            text.enabled = false;

        }

}
