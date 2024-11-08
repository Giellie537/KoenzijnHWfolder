using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Travel : MonoBehaviour
{
    public GameObject travelUI;
    public GameObject koen;
    public GameObject crosshair;
    public PlayerMove playermove;
    public PlayerLook playerlook;
    public CameraLookDetector cameralookdetector;
    private AudioSource audioSource;
    public AudioClip Papiergeluid;

     void Start(){
         audioSource = GetComponent<AudioSource>();
    

    
  }
    public void travelinteract() {
        travelUI.SetActive(true);
        Cursor.visible = true;
        crosshair.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        playermove.enabled = false;
        playerlook.enabled = false;
        cameralookdetector.enabled = false;
    }

    public void closetravel(){ 
        travelUI.SetActive(false);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        playermove.enabled = true;
        playerlook.enabled = true;
        cameralookdetector.enabled = true;
        Debug.Log("close");

    }

    public void travelwoman() {
        SceneManager.LoadScene("angie4.1", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        audioSource.PlayOneShot(Papiergeluid);
    }

    public void travelmain() {
        SceneManager.LoadScene("main", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        audioSource.PlayOneShot(Papiergeluid);
    }

    public void travelsupermarkt() {
        SceneManager.LoadScene("supermarkt5.3", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        audioSource.PlayOneShot(Papiergeluid);
    }

    public void travelhome() {
        SceneManager.LoadScene("backhome", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        audioSource.PlayOneShot(Papiergeluid);
        
    }

    public void traveldorp() {
        SceneManager.LoadScene("dorpsplein3", LoadSceneMode.Single);
         travelUI.SetActive(false);
        koen.SetActive(true);
        Cursor.visible = false;
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        audioSource.PlayOneShot(Papiergeluid);
        
    }
}
