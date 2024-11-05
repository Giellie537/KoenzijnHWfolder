using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quests : MonoBehaviour
{

    public GameObject QuestIndicator;
    public GameObject QuestDropdown;
    public GameObject QuestExtra;
    public GameObject Community;
    public GameObject Questinfo;

    public phone Phone;
    
    public bool extended = false;
    public bool triggered = false;

    //questnew
    public Image buttonimage;
    public Button buttonbutton;
    public GameObject TextParent;
    public Text Questtext;
    public Text Fromtext;
    public Text Desctext;

    public GameObject notif;
    public Text notiftext;

    public bool added = false;
    public bool added2 = false;
    public bool extended2 = false;
    public Text addtext;

    //voor deur script
    public bool quest1 = false;
    public bool quest2 = false;
    

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
                Community.SetActive(false);
                Questinfo.SetActive(false);
            }
        
    }

    public void extend(){
        if(extended == false){
            QuestExtra.SetActive(true);
            extended = true;
            Community.SetActive(false);
            Questinfo.SetActive(true);
        }
        else{
            QuestExtra.SetActive(false);
            extended = false;
        }
    }

    public void extend2(){
            if(extended2 == false){
            Community.SetActive(true);
            extended2 = true;
        }
        else{
            Community.SetActive(false);
            extended2 = false;
        }
    }

    public void addAngie(){
        if(!added){
        //doe cijfertje bij de counter
        QuestsuestSystem.instance.addquest();
        
        //make button visible
        buttonimage.enabled = true;
        buttonbutton.enabled = true;
        TextParent.SetActive(true);

        //change quest description etc
        Questtext.text = "Groceries";
        Fromtext.text = "Angie";
        Desctext.text = "Get groceries for Angie";

        //notification
        notif.SetActive(true);
        notiftext.text = "Quest added";
        StartCoroutine(Textweg());
        added = true;

        //groen
        GetComponent<Image>().color = Color.green;
        quest1 = true;
        }
    }

        IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        notif.SetActive(false);
     }

    public void addTim(){
        if(!added2){
        //doe cijfertje bij de counter
        QuestsuestSystem.instance.addquest();
        
        //make button visible
        buttonimage.enabled = true;
        buttonbutton.enabled = true;
        TextParent.SetActive(true);

        //change quest description etc
        Questtext.text = "Garden";
        Fromtext.text = "Tim";
        Desctext.text = "Help Tim in the community garden";

        //notification
        notif.SetActive(true);
        notiftext.text = "Quest added";
        StartCoroutine(Textweg2());
        added2 = true;

        //groen
        GetComponent<Image>().color = Color.green;
        quest2 = true;
        }
    }

        IEnumerator Textweg2() {
        yield return new WaitForSeconds(3);
        notif.SetActive(false);
     }

     

    }

