using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class angiereturnstart : MonoBehaviour
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
        dialogueText.text = "Koen:\nWow that bus took a while, it's getting late already. I'm afraid I won't be able to help others anymore.";
        StartCoroutine(Textweg());
    }

     IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        DialogueMan.SetActive(false);
     }

}