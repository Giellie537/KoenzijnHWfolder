using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class startauto : MonoBehaviour
{

    public GameObject DialogueMan;
	public TextMeshProUGUI dialogueText;
    
    // Start is called before the first frame update
    void Start()
    {
        QuestsuestSystem.instance.addquest();
        QuestsuestSystem.instance.addquest();
        QuestsuestSystem.instance.addquest();
        QuestsuestSystem.instance.addquest();

        DialogueMan.SetActive(true);
        dialogueText.text = "Sarah(1/11):\nThanks Koen!";
        StartCoroutine(Textweg());
    }

     IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        DialogueMan.SetActive(false);
     }

}
