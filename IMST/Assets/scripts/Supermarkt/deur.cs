using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deur : MonoBehaviour
{

Animator animator;

public void Start(){
    animator = GetComponent<Animator>();
}

public void openen(){
            animator.SetTrigger("open");
}

}
