using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questclose : MonoBehaviour
{

    public GameObject koen;
    public GameObject questboard;
    public PlayerLook playerlook;
    public PlayerMove playermove;
    public CameraLookDetector cameralookdetector;

    public bool added = false;


    public void close(){ 
        questboard.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        playermove.enabled = true;
        playerlook.enabled = true;
        cameralookdetector.enabled = true;
    }
    

    public void clickadd() {
    GetComponent<Image>().color = Color.green;
    added = true;
    }

}
