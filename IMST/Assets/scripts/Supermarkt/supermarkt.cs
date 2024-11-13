using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class supermarkt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QuestsuestSystem.instance.addquest();
        QuestsuestSystem.instance.addquest();
        QuestsuestSystem.instance.addquest();
        QuestsuestSystem.instance.addquest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
