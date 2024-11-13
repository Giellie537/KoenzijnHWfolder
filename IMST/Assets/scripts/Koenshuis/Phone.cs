using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phone : MonoBehaviour
{
private AudioSource AudioSource;
public AudioClip Papiergeluid;
public GameObject Questoverlay;
public Text text;
public bool gepakt = false;
// public MeshRenderer meshrenderer;
public GameObject bg;

public GameObject watch;

void Start(){
     AudioSource = GetComponent<AudioSource>();
}
    public void oppakken() {
        // meshrenderer.enabled = false;
        watch.SetActive(false);
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
        bg.SetActive(false);
        text.enabled = false;
        }

}
