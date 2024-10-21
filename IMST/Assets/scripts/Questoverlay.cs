using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questoverlay : MonoBehaviour
{

    public KeyCode PopupKey = KeyCode.Q;
    public GameObject QuestExtra;
    // private bool triggered;

    void Start(){
        // triggered = false;
        QuestExtra.SetActive(false);

    }

    void Update()
    {


        if(Input.GetKeyDown(PopupKey)) //&& triggered == false){
            print("Q key is held down");
            // QuestExtra.SetActive(true);
            // triggered = true;
            QuestExtra.SetActive(!QuestExtra.activeSelf);

            // if(Input.GetKeyDown(PopupKey) && triggered == true){
            // QuestExtra.SetActive(false);
            // print("close the thing");
            // }
        }

        
    }

