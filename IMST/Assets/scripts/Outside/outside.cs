using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class outside : MonoBehaviour
{

    public GameObject DialogueMan;
	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;
    
    // Start is called before the first frame update
    void Start()
    {
        QuestsuestSystem.instance.addquest();
        QuestsuestSystem.instance.addquest();

        DialogueMan.SetActive(true);
        dialogueText.text = "Koen:\nAngie lives at Sterrenlaan. I should take the bus there.";
        StartCoroutine(Textweg());
    }

     IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        DialogueMan.SetActive(false);
     }

}
