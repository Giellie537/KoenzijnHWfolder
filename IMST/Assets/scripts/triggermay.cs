using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggermay : MonoBehaviour
{

    public bool Triggermay = false;
    public BoxCollider boxcollider;


    public void Triggeron(){
        boxcollider.enabled = true;
        tiggermay = true;

    }


}
