using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class outside : MonoBehaviour
{

    public Text text;
    public Text Questtext;
    public Text Fromtext;
    public Text Desctext;
    
    // Start is called before the first frame update
    void Start()
    {
        QuestsuestSystem.instance.addquest();
        Questtext.text = "Groceries";
        Fromtext.text = "Angie";
        Desctext.text = "Get groceries for Angie";

        text.enabled = true;
        text.text = "Angie lives at Sterrenlaan\nI should take the bus there";
        StartCoroutine(Textweg());
    }

     IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        text.enabled = false;
     }
}
