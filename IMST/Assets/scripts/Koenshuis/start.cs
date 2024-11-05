// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using TMPro;

// public class start : MonoBehaviour
// {
//     public GameObject DialogueMan;
// 	public TextMeshProUGUI nameText;
// 	public TextMeshProUGUI dialogueText;

//     // Start is called before the first frame update
//     void Start()
//     {
//         DialogueMan.SetActive(true);
//         nameText.text = "Koen";
//         dialogueText.text = "I should use E to pick up my phone";
//         StartCoroutine(Textweg());
//     }

//         IEnumerator Textweg() {
//         yield return new WaitForSeconds(3);
//         DialogueMan.SetActive(false);
//      }
// }
