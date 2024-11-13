using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class switchsceneshomeoutside : MonoBehaviour
{
    void OnTriggerEnter() {
        SceneManager.LoadScene("outside4.4", LoadSceneMode.Single);
        Debug.Log ("Trigger");
    }

}
