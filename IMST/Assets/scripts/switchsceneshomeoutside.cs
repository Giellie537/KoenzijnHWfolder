using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class switchsceneshomeoutside : MonoBehaviour
{
    void OnTriggerEnter() {
        SceneManager.LoadScene("outside 3.1", LoadSceneMode.Single);
        Debug.Log ("Trigger");
    }

}
