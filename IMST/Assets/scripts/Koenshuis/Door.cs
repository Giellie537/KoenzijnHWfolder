using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Door : MonoBehaviour
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
public Quests questscript2;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

public void klik1() {
    if (Phone.gepakt == true && questscript.quest1 == true && questscript2.quest2 == true){
        animator.SetTrigger("dooropen");
        audioSource.PlayOneShot(Papiergeluid);
    }

     

     else {
        DialogueMan.SetActive(true);
        nameText.text = "Koen";
        dialogueText.text = "Maybe I should accept a quest for the community before leaving";

        StartCoroutine(Textweg());
     }
}

     IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        DialogueMan.SetActive(false);

     }



}
