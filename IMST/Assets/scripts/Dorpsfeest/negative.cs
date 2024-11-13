using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class negative : MonoBehaviour
{
    public bool hasInteracted = false;
    public int negcount = 0;
    public int negcountAdd = 1;

    public void add(){
        if(!hasInteracted){
        negcount += negcountAdd;
        negcounterscript.AddNegative(negcount);
        Debug.Log(negcounterscript.negtotal);
        hasInteracted = true;
        }
    }
}
