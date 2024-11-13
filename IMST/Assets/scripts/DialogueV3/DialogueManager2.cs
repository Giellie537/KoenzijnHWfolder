using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager2 : MonoBehaviour {

	public GameObject DialogueMan;
	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;


	public int autoCloseInTime = 0;


	private Queue<string> sentences;

	private int count; 
	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
		count = 0;
	}

	public void StartDialogue2 (Dialogue dialogue)
	{
		
		if(count <= 12)
		{
        DialogueMan.SetActive(true);
		nameText.text = dialogue.name;
		Debug.Log("hoppa");

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}
		count++;
		DisplayNextSentence();
		}else{
			EndDialogue();
			count = 0;
			return;
		}
	}

	public void DisplayNextSentence ()
	{
		
		if (sentences.Count == 0)
		{
			// EndDialogue();
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

	public void EndDialogue()
	{
		Debug.Log("hahsghahah");
        DialogueMan.SetActive(false);
        sentences = new Queue<string>();
    }
	
}
