using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManagerMay: MonoBehaviour {

	public GameObject DialogueMan;
	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;

	public int autoCloseInTime = 5;


	private Queue<string> sentences;

	//reference notification
	// public GameObject notif;
    // public Text notiftext;

	public Text questinfo;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
	}

	public void StartDialogue (Dialogue dialogue)
	{
    
        DialogueMan.SetActive(true);
		nameText.text = dialogue.name;

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence ()
	{
		
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence, autoCloseInTime));
	}

	IEnumerator TypeSentence (string sentence, int autoCloseInTime)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}

		//sluit messagebox na X seconden.
		yield return new WaitForSeconds(autoCloseInTime);
        EndDialogue();
    }

	public void EndDialogue(){


        IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        // notif.SetActive(false);
     }

}
}