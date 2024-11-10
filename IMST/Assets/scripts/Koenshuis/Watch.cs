using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class watch : MonoBehaviour
{
private AudioSource AudioSource;
public AudioClip Papiergeluid;
public GameObject Questoverlay;
public Text text;
public bool gepakt = false;
// public MeshRenderer meshrenderer;

public MeshRenderer watcho;

void Start(){
     AudioSource = GetComponent<AudioSource>();
}
    public void oppakken2() {
        // meshrenderer.enabled = false;
        watcho.enabled = false;
        gepakt = true;

        text.text = "Press Q to view quests";
        text.enabled = true;
      
        StartCoroutine(Textweg());
        AudioSource.enabled = false;
        Questoverlay.SetActive(true);
    }

     IEnumerator Textweg() {
        yield return new WaitForSeconds(3);
        text.text = "Press Q to close quest window";
        StartCoroutine(Textweg2());
     }

        IEnumerator Textweg2() {
        yield return new WaitForSeconds(3);
        text.enabled = false;
        }

}

