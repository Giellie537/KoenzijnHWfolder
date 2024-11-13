using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class travelobstruct : MonoBehaviour
{
    public GameObject travelUI;
    public GameObject koen;
    public GameObject crosshair;
    public PlayerMove playermove;
    public PlayerLook playerlook;
    public CameraLookDetector cameralookdetector;
    private AudioSource audioSource;
    public AudioClip Papiergeluid;

    public Quests quests;
    public Quests quests1;

    public GameObject DialogueMan;
	public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;

     void Start1(){
         audioSource = GetComponent<AudioSource>();
    

    
  }
    public void travelinteract1() {
        if(quests.quest1 == true && quests1.quest2){
        travelUI.SetActive(true);
        Cursor.visible = true;
        crosshair.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        playermove.enabled = false;
        playerlook.enabled = false;
        cameralookdetector.enabled = false;
        }

        else{
        DialogueMan.SetActive(true);
        dialogueText.text = "Koen:\nMaybe I should accept some quests for the community before leaving";

        StartCoroutine(Textweg());
     }


     IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        DialogueMan.SetActive(false);

     }
        
    }

    public void closetravel1(){ 
        travelUI.SetActive(false);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        playermove.enabled = true;
        playerlook.enabled = true;
        cameralookdetector.enabled = true;
        Debug.Log("close");

    }

    public void travelwoman1() {
        SceneManager.LoadScene("angie5", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        audioSource.PlayOneShot(Papiergeluid);
    }


    public void travelsupermarkt1() {
        SceneManager.LoadScene("supermarkt10", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        audioSource.PlayOneShot(Papiergeluid);
    }

    public void travelhome1() {
        SceneManager.LoadScene("backhome.1", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        audioSource.PlayOneShot(Papiergeluid);
        
    }

    public void traveldorp1() {
        SceneManager.LoadScene("dorpsplein9.2", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        audioSource.PlayOneShot(Papiergeluid);
        
    }

        public void travelangiereturn1() {
        SceneManager.LoadScene("angiesreturn1.1", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        audioSource.PlayOneShot(Papiergeluid);
        
    }
}

