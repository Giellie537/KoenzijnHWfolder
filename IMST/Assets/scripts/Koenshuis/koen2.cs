using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koen2 : MonoBehaviour
{

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Panelgone());
    }

     IEnumerator Panelgone() {
        yield return new WaitForSeconds(3);
        panel.SetActive(false);

     }
}
