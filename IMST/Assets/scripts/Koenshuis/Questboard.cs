using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questboard : MonoBehaviour
{
public GameObject questboard;
public GameObject koen;
public PlayerMove playermove;
public PlayerLook playerlook;
public CameraLookDetector cameralookdetector;

public void klikquests() {
    questboard.SetActive(true);
    Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
    playermove.enabled = false;
    playerlook.enabled = false;
    cameralookdetector.enabled = false;
}

}
