using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestsuestSystem : MonoBehaviour
{
    public static QuestsuestSystem instance;

    public Text counttext;

    int score = 0;

    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        counttext.text = score.ToString();
    }

    public void addquest(){
        score += 1;
        counttext.text = score.ToString();
    }
}
