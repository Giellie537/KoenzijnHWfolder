using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class outside : MonoBehaviour
{

    public Text text;
    public Text Questtext;
    public Text Fromtext;
    public Text Desctext;


    public GameObject DialogueMan;
	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;
    
    // Start is called before the first frame update
    void Start()
    {
        QuestsuestSystem.instance.addquest();
        Questtext.text = "Groceries";
        Fromtext.text = "Angie";
        Desctext.text = "Get groceries for Angie";

        DialogueMan.SetActive(true);
        nameText.text = "Koen";
        dialogueText.text = "Angie lives at Sterrenlaan. I should take the bus there.";
        StartCoroutine(Textweg());
    }

     IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        DialogueMan.SetActive(false);
     }

}
