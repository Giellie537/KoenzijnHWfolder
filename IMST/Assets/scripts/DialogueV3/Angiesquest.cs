using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Angiesquest : MonoBehaviour{

	public GameObject DialogueMan;
	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;
	
	public int autoCloseInTime = 10;


	private Queue<string> sentences;
private bool hasPlayedAudio = false;
	//reference notification
	public GameObject notif;
    public Text notiftext;

	public Text questinfo;
	private AudioSource audioSource;
    public AudioClip Papiergeluid;

	private int count; 
	public Outline outline;
	// Use this for initialization

	// public float delayTime = 1.0f;

	void Start () {
		sentences = new Queue<string>();
		audioSource = GetComponent<AudioSource>();
		count = 0;
		hasPlayedAudio = false; 
	}

	public void StartDialogue (Dialogue dialogue)
	{
		if(count <= 10)
		{
		DialogueMan.SetActive(true);
		nameText.text = dialogue.name;
		// audioSource.PlayOneShot(Papiergeluid);
		if (!hasPlayedAudio) {
				audioSource.PlayOneShot(Papiergeluid);
				hasPlayedAudio = true; // Zet op true zodat het niet opnieuw wordt afgespeeld
			}
        
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
		// yield return new WaitForSeconds(autoCloseInTime);
        // EndDialogue();
    }

	public void EndDialogue()
	{
		Debug.Log("ikdoet");
        DialogueMan.SetActive(false);
        sentences = new Queue<string>();

		Debug.Log(count);
        //notification
        notif.SetActive(true);
        notiftext.text = "Quest details added";
		questinfo.text = "4kg flour\n3 L milk";
        StartCoroutine(Textweg());
		// StartCoroutine(ReenableDialogueManAfterDelay());

    }

        IEnumerator Textweg() {
        yield return new WaitForSeconds(5);
        notif.SetActive(false);
		// outline.enabled = false;
		
     }
	 
	//  IEnumerator ReenableDialogueManAfterDelay() {
    // yield return new WaitForSeconds(delayTime);  
    // DialogueMan.SetActive(true);                 
// }
	
	


}