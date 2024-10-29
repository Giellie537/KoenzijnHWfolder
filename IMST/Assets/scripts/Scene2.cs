using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scene2 : MonoBehaviour
{

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
    }


}
