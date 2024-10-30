using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melk : MonoBehaviour
{
    public bool melkgepakt = false;
    public MeshRenderer meshmelk;

        public void melkpakken(){
        meshmelk.enabled = false;
        melkgepakt = true;
    }
}
