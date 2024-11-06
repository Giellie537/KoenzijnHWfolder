using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact_test_script : MonoBehaviour
{
    public GameObject DialogueMan;

    public void interact() {
        DialogueMan.SetActive(true);
        StartCoroutine(Textweg());
     }


     IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        DialogueMan.SetActive(false);

     }

}
