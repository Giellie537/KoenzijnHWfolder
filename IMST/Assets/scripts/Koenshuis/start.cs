using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour
{

    public Text helptext;


    // Start is called before the first frame update
    void Start(){
        helptext.text = "Use WASD to move";
        helptext.enabled = true;
        }

    void OnTriggerEnter() {
        helptext.text = "Use E to interact with objects or people";
    }

}
