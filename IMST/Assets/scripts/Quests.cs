using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quests : MonoBehaviour
{

    public GameObject QuestIndicator;
    public GameObject QuestDropdown;
    public bool triggered = false;
    public phone Phone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && triggered == false && Phone.gepakt == true){
            QuestDropdown.SetActive(true);
            triggered = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else if(Input.GetKeyDown(KeyCode.Q) && triggered == true){
                QuestDropdown.SetActive(false);
                triggered = false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
    }
}
