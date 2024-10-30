using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meel : MonoBehaviour
{

    public bool meelgepakt = false;
    public MeshRenderer meshmeel;


    public void meelpakken(){
        meshmeel.enabled = false;
        meelgepakt = true;
    }


}
