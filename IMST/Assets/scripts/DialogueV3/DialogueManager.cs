using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DialogueManager : MonoBehaviour {

	public GameObject DialogueMan;
	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;
	
	

	public int autoCloseInTime = 0;


	private Queue<string> sentences;

	//reference notification
	public GameObject notif;
    public Text notiftext;

	public Text questinfo;
	private AudioSource audioSource;
    public AudioClip Papiergeluid;

	private int count; 
	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
		audioSource = GetComponent<AudioSource>();
		count = 0;
	}

	public void StartDialogue (Dialogue dialogue)
	{
		if(count <= 10)
		{
		DialogueMan.SetActive(true);
		nameText.text = dialogue.name;
		audioSource.PlayOneShot(Papiergeluid);
        
		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}
		count++;
		DisplayNextSentence();
		} else{
			EndDialogue();
			count = 0;
			return;
			
			
		}
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
		//yield return new WaitForSeconds(autoCloseInTime);
        //EndDialogue();
    }

	public void EndDialogue()
	{
        DialogueMan.SetActive(false);
        sentences = new Queue<string>();

		Debug.Log(count);
        //notification
        notif.SetActive(true);
        notiftext.text = "Quest details added";
		questinfo.text = "4kg flour\n3 L milk";
        StartCoroutine(Textweg());

    }

        IEnumerator Textweg() {
        yield return new WaitForSeconds(2);
        notif.SetActive(false);
     }
	 
	
	

}
