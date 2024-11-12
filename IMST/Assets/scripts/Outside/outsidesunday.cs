using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class outsidesunday : MonoBehaviour
{

    public GameObject DialogueMan;
	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;
    
    // Start is called before the first frame update
    void Start()
    {
        DialogueMan.SetActive(true);
        dialogueText.text = "Koen:\nAllright, time to go to the market.";
        StartCoroutine(Textweg());
    }

     IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        DialogueMan.SetActive(false);
     }

}
