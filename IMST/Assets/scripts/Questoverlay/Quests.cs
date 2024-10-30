using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quests : MonoBehaviour
{

    public GameObject QuestIndicator;
    public GameObject QuestDropdown;
    public GameObject QuestExtra;

    public phone Phone;
    
    public bool extended = false;
    public bool triggered = false;

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
                QuestExtra.SetActive(false);
            }
        
    }

    public void extend(){
        if(extended == false){
            QuestExtra.SetActive(true);
            extended = true;
        }
        else{
            QuestExtra.SetActive(false);
            extended = false;
        }
    }
}
