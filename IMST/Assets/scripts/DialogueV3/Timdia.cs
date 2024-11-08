using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timdia : MonoBehaviour {

	public GameObject DialogueMan;
	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;

    public Image buttonimage;
    public Button buttonbutton;
    public GameObject TextParent;

	public int autoCloseInTime = 0;

	private AudioSource audioSource;
    public AudioClip Papiergeluid;

	private Queue<string> sentences;

	//reference notification
	// public GameObject notif;
    // public Text notiftext;

	public Text questinfo;
private int count; 
	// Use this for initialization
	void Start1 () {
		// sentences = new Queue<string>();
		audioSource = GetComponent<AudioSource>();    
		 count = 0;
	}

	public void StartDialogue1 (Dialogue dialogue)
	{
    if(count <= 6)
		{
        DialogueMan.SetActive(true);
		nameText.text = dialogue.name;
		audioSource.PlayOneShot(Papiergeluid);

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		count++;
		DisplayNextSentence1();
		} else{
			EndDialogue();
			count = 0;
			return;
		}
	}

	public void DisplayNextSentence1 ()
	{
		
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence1(sentence, autoCloseInTime));
	}

	IEnumerator TypeSentence1 (string sentence, int autoCloseInTime)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}

		// //sluit messagebox na X seconden.
		// yield return new WaitForSeconds(autoCloseInTime);
        // EndDialogue1();
    }

	public void EndDialogue()
	{
        // DialogueMan.SetActive(false);
        // sentences = new Queue<string>();
		// Debug.Log("end");

        // //notification
        // notif.SetActive(true);
        // notiftext.text = "Quest details added";

        // buttonimage.enabled = true;
        // buttonbutton.enabled = true;
        // TextParent.SetActive(true);
        // QuestsuestSystem.instance.addquest();

        // StartCoroutine(Textweg3());

    }

        IEnumerator Textweg3() {
        yield return new WaitForSeconds(3);
        // notif.SetActive(false);
     }

}
