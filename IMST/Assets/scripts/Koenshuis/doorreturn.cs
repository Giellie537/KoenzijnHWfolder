using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class doorreturn : MonoBehaviour
{

Animator animator;
public Text text;
public phone Phone;
public Questclose questclose;
private AudioSource audioSource;
public AudioClip Papiergeluid;

public GameObject DialogueMan;
public TextMeshProUGUI nameText;
public TextMeshProUGUI dialogueText;

public Quests questscript;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

public void klik1() {
    if (questscript.openend == true){
        animator.SetTrigger("dooropen");
        audioSource.PlayOneShot(Papiergeluid);
    }

     

     else {
        DialogueMan.SetActive(true);
        dialogueText.text = "Koen:\nI should check for quests first.";

        StartCoroutine(Textweg());
     }
}

     IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        DialogueMan.SetActive(false);

     }



}
