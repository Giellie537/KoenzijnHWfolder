using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggermay : MonoBehaviour
{

    public bool triggered = false;
    public BoxCollider boxcollider;
    public GameObject sarahcar;


    public void Triggeron(){
        boxcollider.enabled = true;
        triggered = true;
        sarahcar.SetActive(true);
    }


}
