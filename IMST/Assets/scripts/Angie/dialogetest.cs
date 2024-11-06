using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueMayQuest : MonoBehaviour
{
    public GameObject DialogueMan;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public Image buttonImage;
    public Button buttonButton;
    public GameObject textParent;

    private Queue<string> sentences;
    private bool isDialogueActive = false; // Controleert of de dialoog al gestart is

    // Referentie naar notificatie
    public GameObject notif;
    public Text notifText;

    public Text questInfo;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        // Controleer of de dialoog al actief is
        if (isDialogueActive)
        {
            Debug.Log("Dialogue is already active.");
            return;
        }

        // Zet de dialoog als actief
        isDialogueActive = true;
        DialogueMan.SetActive(true);
        nameText.text = dialogue.name;

        // Vul de queue met zinnen uit de dialoog
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence(); // Start met de eerste zin
    }

    public void DisplayNextSentence()
    {
        // Controleer of er nog zinnen over zijn
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        // Toon de volgende zin
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        DialogueMan.SetActive(false);
        isDialogueActive = false; // Reset de dialoogstatus
        sentences.Clear();

        // Toon notificatie
        notif.SetActive(true);
        notifText.text = "Quest details added";

        buttonImage.enabled = true;
        buttonButton.enabled = true;
        textParent.SetActive(true);

        StartCoroutine(HideNotification());
    }

    IEnumerator HideNotification()
    {
        yield return new WaitForSeconds(3);
        notif.SetActive(false);
    }

    void Update()
    {
        // Laat de speler op een knop klikken om naar de volgende zin te gaan
        if (isDialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextSentence();
        }
    }
}
